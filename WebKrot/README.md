# Create react app in docker

Create docker hub repository - publish
```
docker build -t npr211-api . 
docker run -it --rm -p 6193:8080 --name npr211_container npr211-api
docker run -d --restart=always --name npr211_container -p 6193:8080 npr211-api
docker ps -a
docker stop npr211_container
docker rm npr211_container

docker images --all
docker rmi npr211-api

docker login
docker tag npr211-api:latest novakvova/npr211-api:latest
docker push novakvova/npr211-api:latest

docker pull novakvova/npr211-api:latest
docker ps -a
docker run -d --restart=always --name npr211_container -p 6193:8080 novakvova/npr211-api


docker pull novakvova/npr211-api:latest
docker images --all
docker ps -a
docker stop npr211_container
docker rm npr211_container
docker run -d --restart=always --name npr211_container -p 6193:8080 novakvova/npr211-api
```

```nginx options /etc/nginx/sites-available/default
server {
    server_name   npr211.novakv.com *.npr211.novakv.com;
    location / {
       proxy_pass         http://localhost:6193;
       proxy_http_version 1.1;
       proxy_set_header   Upgrade $http_upgrade;
       proxy_set_header   Connection keep-alive;
       proxy_set_header   Host $host;
       proxy_cache_bypass $http_upgrade;
       proxy_set_header   X-Forwarded-For $proxy_add_x_forwarded_for;
       proxy_set_header   X-Forwarded-Proto $scheme;
    }
}

sudo systemctl restart nginx
certbot
```



