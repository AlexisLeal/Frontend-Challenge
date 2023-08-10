FROM node:18-alpine
WORKDIR /app
EXPOSE 4200
RUN npm install -g @angular/cli@16