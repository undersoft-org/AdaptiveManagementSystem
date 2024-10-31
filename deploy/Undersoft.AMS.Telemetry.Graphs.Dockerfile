ARG GRAFANA_VERSION="latest"

FROM grafana/grafana:10.1.5

USER root
RUN apk add --update-cache --upgrade curl

ARG GF_INSTALL_PLUGINS="alexanderzobnin-zabbix-app,briangann-gauge-panel,cloudflare-app,digiapulssi-breadcrumb-panel,digiapulssi-organisations-panel,digrich-bubblechart-panel,fetzerch-sunandmoon-datasource,fzakaria-simple-annotations-datasource,grafana-clock-panel,grafana-piechart-panel,grafana-simple-json-datasource,grafana-worldmap-panel,jdbranham-diagram-panel,mtanda-google-calendar-datasource,natel-discrete-panel,natel-influx-admin-panel,neocat-cal-heatmap-panel,novalabs-annotations-panel,petrslavotinek-carpetplot-panel,raintank-kubernetes-app,savantly-heatmap-panel,vonage-status-panel,grafana-polystat-panel,farski-blendstat-panel,citilogics-geoloop-panel,larona-epict-panel,pierosavi-imageit-panel,zuburqan-parity-report-panel,jeanbaptistewatenberg-percent-panel,corpglory-progresslist-panel,snuids-radar-panel,blackmirror1-singlestat-math-panel,mxswat-separator-panel,blackmirror1-statusbygroup-panel,flant-statusmap-panel,pr0ps-trackmap-panel,snuids-trafficlights-panel,fatcloud-windrose-panel,sbueringer-consul-datasource,andig-darksky-datasource,ayoungprogrammer-finance-datasource,grafana-influxdb-flux-datasource,xginn8-pagerduty-datasource,camptocamp-prometheus-alertmanager-datasource,jasonlashua-prtg-datasource,raintank-worldping-app,cloudflare-app,grafana-googlesheets-datasource,grafana-oncall-app"

RUN if [ ! -z "${GF_INSTALL_PLUGINS}" ]; then \
    OLDIFS=$IFS; \
        IFS=','; \
    for plugin in ${GF_INSTALL_PLUGINS}; do \
        IFS=$OLDIFS; \
        grafana-cli --pluginsDir "$GF_PATHS_PLUGINS" plugins install ${plugin}; \
    done; \
fi

USER 104

HEALTHCHECK --interval=10s --timeout=10s --retries=10 CMD curl -f http://localhost:3000/ || exit 1