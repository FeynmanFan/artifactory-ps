# JFrog Artifactory Fundamentals

This is the official Github repository for the course "JFrog Artifactory Fundamentals" from PluralSight.

## Promised Commands
1. The docker command to create your own Jenkins instance to work with is as follows:

`docker run --restart always --name jenkins-docker -p 8080:8080 jenkins/jenkins:lts`

2. The command to add a Nuget source on Linux in clear text looks like this:

`dotnet nuget add source {repo url} -n {source name} -u $username -p $password --configfile {path to LOCAL config file} --store-password-in-clear-text`
