# Copyright (c) 2024 The Jaeger Authors.
# SPDX-License-Identifier: Apache-2.0

FROM jaegertracing/all-in-one:latest

ARG TARGETARCH=amd64
ARG USER_UID=10001

# Collector OTLP gRPC
EXPOSE 4317

# Collector OTLP HTTP
EXPOSE 4318

# Collector HTTP
EXPOSE 14268

# Collector gRPC
EXPOSE 14250

# Collector Zipkin
EXPOSE 9411

# Web HTTP
EXPOSE 16686