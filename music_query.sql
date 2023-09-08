SELECT
    t.artist,
    t.title,
    t.genre,
    t.duration
FROM
    tracks AS t
JOIN
    albums AS a ON t.album_id = a.album_id
JOIN
    artists AS ar ON a.artist_id = ar.artist_id
WHERE
    t.release_date >= DATEADD(YEAR, -1, GETDATE())
ORDER BY
    ar.artist_name ASC,
    t.title ASC;
