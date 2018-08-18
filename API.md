# API Documentation

**API Endpoints**
* List Movies
* Movie Details
* Movie Suggestions
* Movie Comments
* Movie Reviews
* Movie Parental Guides
* List Upcoming


status	The returned status for the API call, can be either 'ok' or 'error'	ok
status_message	Either the error message or the successful message	Query was successful
data	If 'status' is returned as 'ok' the API query results will be inside 'data'	data

List Movies HTTP GET
https://yts.am/api/v2/list_movies.json
https://yts.am/api/v2/list_movies.jsonp
https://yts.am/api/v2/list_movies.xml	

Endpoint Parameters
limit		Integer between 1 - 50 (inclusive)	20	The limit of results per page that has been set
page		Integer (Unsigned)	1	Used to see the next page of movies, eg limit=15 and page=2 will show you movies 15-30
quality		String (720p, 1080p, 3D)	All	Used to filter by a given quality
minimum_rating		Integer between 0 - 9 (inclusive)	0	Used to filter movie by a given minimum IMDb rating
query_term		String	0	Used for movie search, matching on: Movie Title/IMDb Code, Actor Name/IMDb Code, Director Name/IMDb Code
genre		String	All	Used to filter by a given genre (See http://www.imdb.com/genre/ for full list)
sort_by		String (title, year, rating, peers, seeds, download_count, like_count, date_added)	date_added	Sorts the results by choosen value
order_by		String (desc, asc)	desc	Orders the results by either Ascending or Descending order
with_rt_ratings		Boolean	false	Returns the list with the Rotten Tomatoes rating included
Examples
URL	Description
https://yts.am/api/v2/list_movies.json?quality=3D	Returns the latest 20 3D movies using JSON format
https://yts.am/api/v2/list_movies.xml?sort=seeds&limit=15	Returns maximum 15 movies which are sorted by seeds
Response Data
Key Name	Description	Example
movie_count	The total movie count results for your query	2131
limit	The limit of results per page that has been set	20
page_number	The current page number you are viewing	1
movies	An array which will hold multiple movies and their relative information	ARRAY To get Magnet URLs you need to construct this yourself like so:

magnet:?xt=urn:btih:TORRENT_HASH&dn=Url+Encoded+Movie+Name&tr=http://track.one:1234/announce&tr=udp://track.two:80

You can add as many trackers as you want, we recommend the following:

- udp://open.demonii.com:1337/announce
- udp://tracker.openbittorrent.com:80
- udp://tracker.coppersurfer.tk:6969
- udp://glotorrents.pw:6969/announce
- udp://tracker.opentrackr.org:1337/announce
- udp://torrent.gresille.org:80/announce
- udp://p4p.arenabg.com:1337
- udp://tracker.leechers-paradise.org:6969
Movie Details
HTTP GET
Endpoint	Description
https://yts.am/api/v2/movie_details.json
https://yts.am/api/v2/movie_details.jsonp
https://yts.am/api/v2/movie_details.xml	Returns the information about a specific movie
Endpoint Parameters
Parameter	Required	Type	Default	Description
movie_id		Integer (Unsigned)	null	The ID of the movie
with_images		Boolean	false	When set the data returned will include the added image URLs
with_cast		Boolean	false	When set the data returned will include the added information about the cast
Examples
URL	Description
https://yts.am/api/v2/movie_details.json?movie_id=10	Returns basic information about the movie with ID of 10
https://yts.am/api/v2/movie_details.json?movie_id=15&with_images=true&with_cast=true	Returns the full information (with image urls and cast information) about the movie with ID of 15 To get Magnet URLs you need to construct this yourself like so:

magnet:?xt=urn:btih:TORRENT_HASH&dn=Url+Encoded+Movie+Name&tr=http://track.one:1234/announce&tr=udp://track.two:80

You can add as many trackers as you want, we recommend the following:

- udp://glotorrents.pw:6969/announce
- udp://tracker.opentrackr.org:1337/announce
- udp://torrent.gresille.org:80/announce
- udp://tracker.openbittorrent.com:80
- udp://tracker.coppersurfer.tk:6969
- udp://tracker.leechers-paradise.org:6969
- udp://p4p.arenabg.ch:1337
- udp://tracker.internetwarriors.net:1337
Movie Suggestions
HTTP GET
Endpoint	Description
https://yts.am/api/v2/movie_suggestions.json
https://yts.am/api/v2/movie_suggestions.jsonp
https://yts.am/api/v2/movie_suggestions.xml	Returns 4 related movies as suggestions for the user
Endpoint Parameters
Parameter	Required	Type	Default	Description
movie_id		Integer (Unsigned)	null	The ID of the movie
Examples
URL	Description
https://yts.am/api/v2/movie_suggestions.json?movie_id=10	Returns related movies to the movie with ID of 10
Movie Comments
HTTP GET
Endpoint	Description
https://yts.am/api/v2/movie_comments.json
https://yts.am/api/v2/movie_comments.jsonp
https://yts.am/api/v2/movie_comments.xml	Returns all the comments for the specified movie
Endpoint Parameters
Parameter	Required	Type	Default	Description
movie_id		Integer (Unsigned)	null	The ID of the movie
Examples
URL	Description
https://yts.am/api/v2/movie_comments.json?movie_id=10	Returns all the comments for the movie with ID of 10
Movie Reviews
HTTP GET
Endpoint	Description
https://yts.am/api/v2/movie_reviews.json
https://yts.am/api/v2/movie_reviews.jsonp
https://yts.am/api/v2/movie_reviews.xml	Returns all the IMDb movie reviews for the specified movie
Endpoint Parameters
Parameter	Required	Type	Default	Description
movie_id		Integer (Unsigned)	null	The ID of the movie
Examples
URL	Description
https://yts.am/api/v2/movie_reviews.json?movie_id=10	Returns IMDb movie reviews for the movie with ID of 10
Movie Parental Guides
HTTP GET
Endpoint	Description
https://yts.am/api/v2/movie_parental_guides.json
https://yts.am/api/v2/movie_parental_guides.jsonp
https://yts.am/api/v2/movie_parental_guides.xml	Returns all the parental guide ratings for the specified movie
Endpoint Parameters
Parameter	Required	Type	Default	Description
movie_id		Integer (Unsigned)	null	The ID of the movie
Examples
URL	Description
https://yts.am/api/v2/movie_parental_guides.json?movie_id=10	Returns the parental guides for the movie with the ID of 10
List Upcoming
HTTP GET
Endpoint	Description
https://yts.am/api/v2/list_upcoming.json
https://yts.am/api/v2/list_upcoming.jsonp
https://yts.am/api/v2/list_upcoming.xml	Returns the 4 latest upcoming movies
Examples
URL	Description
https://yts.am/api/v2/list_upcoming.json	Returns the 4 latest upcoming movies
User Details
HTTP GET
Endpoint	Description
https://yts.am/api/v2/user_details.json
https://yts.am/api/v2/user_details.jsonp
https://yts.am/api/v2/user_details.xml	Get the user details
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_id		Integer (Unsigned)	null	The ID of the user
with_recently_downloaded		Boolean	null	If set it will add the most recent downloads by the specified user
Examples
URL	Description
https://yts.am/api/v2/user_details.json?user_id=16	Returns user profile information for the user with the ID of 16
Get User Key
HTTP POST
Endpoint	Description
https://yts.am/api/v2/user_get_key.json
https://yts.am/api/v2/user_get_key.jsonp
https://yts.am/api/v2/user_get_key.xml	The same as logging in, if successful the returned data will include the user_key for later use of the API as a means of authentication
Endpoint Parameters
Parameter	Required	Type	Default	Description
username		String	null	The username of the user you wish to authenticate
password		String	null	The password of the user you wish to authenticate
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
User Profile
HTTP GET
Endpoint	Description
https://yts.am/api/v2/user_profile.json
https://yts.am/api/v2/user_profile.jsonp
https://yts.am/api/v2/user_profile.xml	This endpoint will return the full information about an authenticated user
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
Examples
URL	Description
https://yts.am/api/v2/user_profile.json?user_key=1e2b2baddff6234	Returns the full information about an authenticated user
Edit User Settings
HTTP POST
Endpoint	Description
https://yts.am/api/v2/user_edit_settings.json
https://yts.am/api/v2/user_edit_settings.jsonp
https://yts.am/api/v2/user_edit_settings.xml	Endpoint is used to edit an authenticated user's profile settings
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
new_password		String	null	The new desired password
about_text		String	null	Text describing the user in a short paragraph
avatar_image		img, jpg, jpeg, gif, png (10MB max)	null	Upload (using multi-part) a new avatar image
Register User
HTTP POST
Endpoint	Description
https://yts.am/api/v2/user_register.json
https://yts.am/api/v2/user_register.jsonp
https://yts.am/api/v2/user_register.xml	Endpoint is used register a new user
Endpoint Parameters
Parameter	Required	Type	Default	Description
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
username		String	null	The desired username
password		String	null	The desired password
email		String	null	The email address of the new user
Forgot User Password
HTTP POST
Endpoint	Description
https://yts.am/api/v2/user_forgot_password.json
https://yts.am/api/v2/user_forgot_password.jsonp
https://yts.am/api/v2/user_forgot_password.xml	Endpoint is used to get a password reset code sent to their email to in case the user forgot their password
Endpoint Parameters
Parameter	Required	Type	Default	Description
email		String	null	The email address of the user to send the reset password code
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Reset User Password
HTTP POST
Endpoint	Description
https://yts.am/api/v2/user_reset_password.json
https://yts.am/api/v2/user_reset_password.jsonp
https://yts.am/api/v2/user_reset_password.xml	Endpoint is used to reset the user's password using the password reset code
Endpoint Parameters
Parameter	Required	Type	Default	Description
reset_code		String	null	The reset code which was sent to the user's email
new_password		String	null	The newly desired password
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Like Movie
HTTP POST
Endpoint	Description
https://yts.am/api/v2/like_movie.json
https://yts.am/api/v2/like_movie.jsonp
https://yts.am/api/v2/like_movie.xml	Endpoint is used to send a like (heart) for a specific movie
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
movie_id		Integer (Unsigned)	null	The ID of the movie
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Get Movie Bookmarks
HTTP GET
Endpoint	Description
https://yts.am/api/v2/get_movie_bookmarks.json
https://yts.am/api/v2/get_movie_bookmarks.jsonp
https://yts.am/api/v2/get_movie_bookmarks.xml	Endpoint is used to get all the current movies which have been bookmarked for a given user
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
with_rt_ratings		Boolean	false	Returns the list with the Rotten Tomatoes rating included
Examples
URL	Description
https://yts.am/api/v2/get_movie_bookmarks.json?user_key=1e2b2baddff6234	Returns the list of bookmarked movies for an authenticated user
Add Movie Bookmark
HTTP POST
Endpoint	Description
https://yts.am/api/v2/add_movie_bookmark.json
https://yts.am/api/v2/add_movie_bookmark.jsonp
https://yts.am/api/v2/add_movie_bookmark.xml	Endpoint is used to add any specific movie to the user's bookmarks
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
movie_id		Integer (Unsigned)	null	The ID of the movie
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Delete Movie Bookmark
HTTP POST
Endpoint	Description
https://yts.am/api/v2/delete_movie_bookmark.json
https://yts.am/api/v2/delete_movie_bookmark.jsonp
https://yts.am/api/v2/delete_movie_bookmark.xml	Endpoint is used remove movies from the user's bookmarks
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
movie_id		Integer (Unsigned)	null	The ID of the movie
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Make Comment
HTTP POST
Endpoint	Description
https://yts.am/api/v2/make_comment.json
https://yts.am/api/v2/make_comment.jsonp
https://yts.am/api/v2/make_comment.xml	Endpoint is used allow a user to post a comment on a specific movie
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
movie_id		Integer (Unsigned)	null	The ID of the movie
comment_text		Integer (Unsigned)	null	The text that the user wants to submit as the comment
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Like Comment
HTTP POST
Endpoint	Description
https://yts.am/api/v2/like_comment.json
https://yts.am/api/v2/like_comment.jsonp
https://yts.am/api/v2/like_comment.xml	Endpoint is used allow a user like (heart) a comment
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
comment_id		Integer (Unsigned)	null	The ID of the comment
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Report Comment
HTTP POST
Endpoint	Description
https://yts.am/api/v2/report_comment.json
https://yts.am/api/v2/report_comment.jsonp
https://yts.am/api/v2/report_comment.xml	Endpoint is used allow a user to report a comment
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
comment_id		Integer (Unsigned)	null	The ID of the comment
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Delete Comment
HTTP POST
Endpoint	Description
https://yts.am/api/v2/delete_comment.json
https://yts.am/api/v2/delete_comment.jsonp
https://yts.am/api/v2/delete_comment.xml	Endpoint is used allow a user to delete a comment (assuming its their own)
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
comment_id		Integer (Unsigned)	null	The ID of the comment
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE
Make Request
HTTP POST
Endpoint	Description
https://yts.am/api/v2/make_request.json
https://yts.am/api/v2/make_request.jsonp
https://yts.am/api/v2/make_request.xml	Endpoint is used allow a user create a movie request
Endpoint Parameters
Parameter	Required	Type	Default	Description
user_key		String	null	The key that you get from authenticating using the API (Get User Key endpoint)
movie_title		String	null	The title of the movie
request_message		String	null	Optional extra information about the request.
application_key		String	null	To make any POST requests to our API you must use your developer's 'application_key', if you do not have one please apply HERE