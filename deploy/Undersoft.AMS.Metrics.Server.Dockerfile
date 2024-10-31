FROM prom/prometheus
ADD prometheus.yml /etc/prometheus/

EXPOSE 9090:9090