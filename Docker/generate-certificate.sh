sudo wget https://dl.eff.org/certbot-auto
sudo chmod a+x ./certbot-auto
export LC_ALL="en_US.UTF-8"
export LC_CTYPE="en_US.UTF-8"
sudo ./certbot-auto
sudo ./certbot-auto certonly --server https://acme-v02.api.letsencrypt.org/directory --manual --preferred-challenges dns -d *.saavly.com -d saavly.com

openssl pkcs12 -export -out certificate.pfx -inkey privateKey.key -in certificate.crt