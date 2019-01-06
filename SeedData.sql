INSERT INTO Website (WebsiteId, Name, SiteUrl) VALUES (1, 'Evil Angel', 'https://www.evilangel.com');

INSERT INTO Tag (TagId, Name) VALUES (1, 'Edging');
INSERT INTO Tag (TagId, Name) VALUES (2, 'Blowjob');
INSERT INTO Tag (TagId, Name) VALUES (3, 'Anal');
INSERT INTO Tag (TagId, Name) VALUES (4, 'Facial');

INSERT INTO Video (VideoId, Name, Path, PreviewPath, PosterImagePath, Rating, DvdId, WebsiteId) VALUES (1, '1881572', 'https://localhost:44365/static/Clips/1881572.mp4', 'https://localhost:44365/static/ClipKeeperData/previews/9135b569-fb35-4fcd-bfcc-e2808147c459.mp4', 'https://localhost:44365/static/ClipKeeperData/posters/e74439a2-5c2e-4320-8f3e-9200a8e9233b.png', 3, NULL, 1);
INSERT INTO Video (VideoId, Name, Path, PreviewPath, PosterImagePath, Rating, DvdId, WebsiteId) VALUES (2, 'Asa Akira Hot', 'https://localhost:44365/static/Clips/2%20Asa%20Akira.mp4', 'https://localhost:44365/static/ClipKeeperData/previews/b721e37b-7baa-48f1-8c36-4a90c4ebdcd6.mp4', 'https://localhost:44365/static/ClipKeeperData/posters/6df81c90-7615-418b-9be8-75b1ae4c1d51.png', 2, NULL, NULL);

INSERT INTO Performer (PerformerId, Name, Rating, Gender) VALUES (1, 'Kate England', 4, 'Female');
INSERT INTO Performer (PerformerId, Name, Rating, Gender) VALUES (2, 'Asa Akira', 4, 'Female');
INSERT INTO Performer (PerformerId, Name, Rating, Gender) VALUES (3, 'Mick Blue', 0, 'Male');

INSERT INTO PerformerVideo (PerformerId, VideoId) VALUES (1, 1);
INSERT INTO PerformerVideo (PerformerId, VideoId) VALUES (2, 2);
INSERT INTO PerformerVideo (PerformerId, VideoId) VALUES (3, 2);

INSERT INTO VideoTag (VideoId, TagId) VALUES (1, 1);
INSERT INTO VideoTag (VideoId, TagId) VALUES (2, 2);
INSERT INTO VideoTag (VideoId, TagId) VALUES (2, 3);
INSERT INTO VideoTag (VideoId, TagId) VALUES (2, 4);