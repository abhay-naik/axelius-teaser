docker container stop $(docker ps -a -q)
# $reset = Read-Host -Prompt 'Do you wish to reset docker installations? (y/n)'
# if($reset -eq 'y')
# {
# 	docker system prune --all --force --volumes
# }
docker-compose -f docker-compose.yml up -d