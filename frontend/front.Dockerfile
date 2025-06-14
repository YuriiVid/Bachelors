FROM node:23.11-alpine
 
WORKDIR /app 
COPY package*.json ./

RUN npm install
COPY . .

EXPOSE 3000
 
CMD [ "npm", "run", "dev" ]
