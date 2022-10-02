library(tidyverse)
library(lubridate)
library(readxl)

dataset = read_excel("VerkoopSupermarktProducten.xlsx")

con = DBI::dbConnect(RSQLite::SQLite(), ":memory:")
copy_to(con, dataset, overwrite = TRUE)

knitr::opts_chunk$set(connection = "con")

dbExecute(con, "
    UPDATE dataset SET besteldatum = DATE(besteldatum, \'unixepoch\'), leverdatum = DATE(leverdatum, \'unixepoch\'), betaaldatum = DATE(betaaldatum, \'unixepoch\');

    select *
    from dataset
")

dbExecute(con, "
    select regiocode, count(klantnr)
    from dataset
    group by regiocode
")

dbExecute(con, "
    select count(distinct verkoper) as aantalVerkopers
    from dataset
")

dbExecute(con, "
    select regiocode, count(distinct verkoper)
    from dataset
    group by regiocode
")

