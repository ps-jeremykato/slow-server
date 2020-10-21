# Slow Server

This service imitates a server being slow to respond, which may be useful for testing applications that need to handle timeout edge cases.

The main controller is configured to sleep for a set duration before responding to the request, and matches against any request route.
