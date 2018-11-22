# .Net API

POC for testing the viability of using .net framework to meet TBS standards

## Goals

To create a simple, unified, extensible way to rapidly develop TBS API specification compliant APIs.

The APIs must:

- performance
  - use bandwidth sparingly
    - return JSON at a minimum, and XML only if there is a strong business case for it and defined in Accept header (optionally in 'type' query parameter)
  - short-circuit bad requests (invalid languages, media types, and/or pagination values)
  - use connection pools
  - allow for requesting only the total number of results from a query
- follow REST standards
  - (use the plural to define collections)
  - restrict HTTP methods to GET, POST, PUT, DELETE and use them to perform approriate CRUD operations
  - represent entities via a unique URL
  - use HATEOAS to provide additional identifying information to clients on consuming data
- use utf-8 encoding and ISO-8601 datetimes
- responses should be well defined:
  - (provide a point of contact in metadata)
  - avoid returning only the data in list/array form, objects allow for greater flexibility with regards to metadata and modification in the future (consider using `data` as the key)
  - use consistent key naming (camelCase)
  - structured responses limiting server generated additional fields (allowance for fields to be filtered, though)
  - avoid raw data structures, provide abstractions over them
  - prefer compositional rather than relational data structures
  - avoid generic placeholder keys
  - standardize error codes and conform to well-known HTTP status codes and provide meaningful messages
  - do not divulge server output such as logs or runtime errors
  - all interactions with client should be stateless
    - issues related to sessions such as rate limiting and access will be handled at a higher level
- have language specific data condensed into a map with a representative name, with language codes (`en`, `fr`) as keys defining the language specific data
- language-dependant responses:
  - desired language can be expresses via ~~unilingual endpoint,~~ Accept-Language header, or possibly path/query parameters
  - if no language is specified, return all available languages
  - if one or more language is specified, return all available requested languages
  - if languages are specified but do not match any available languages, throw language error or return all available
  - query parameter takes priority over headers
- for datasets large enough to cause performance issues, allow for pagination mechanism or secure file transfer
- allow for some form of querying, at a minimum with path parameters, optionally with a query DSL for query parameters and/or in a GET request body (needs to be define)
- test the API
  - use TDD
  - do performance/load testing
  - measure and publish test results
- sanitize requests
  - prevent common attack vectors like SQL injection or regex explosion by restricting wildcards and validating user input
- use versioning when implementing/deprecating functionality
- API should be well documented and bilingual using OpenAPI specification, possibly with generating tools
- provide point of contact and SLA in documentation
- issues related to IP filtering, authentication, rate-limiting, throttling, etc. should be handle at a higher level (API store)

## Suggested Parameters

- these could be available as query parameters or as keys in a GET body request JSON object
- if a request body is present, it will take precedence

- `type` - `xml` or `json`, only required if API returns XML
- `languages` - `en` and/or `fr` comma separated string of acceptable languages
- `query` - object describing additional filter parameters using some DSL (optional)
- `limit` - define page size for endpoints
- `page` - define page number - for page-based processing such as with tables
- `offset` - define offset from 0 - for more programmatic access
- `total` - return only the number of records (takes precendence over all paging mechanisms)
- `sortBy` - 
- `fields` - specify which fields are to be returned (optional)

NOTE: page and offset are mutually exclusive, with page taking precedence

## TODO

- [ ] shortcut api calls using filters
- [ ] manage languages for ~~unilingual endpoints,~~ Accept header, and possibly 'languages' query or a path parameter
- [x] manage content type for Accept header, and possibly with 'type' query param (support XML out of the box)
- [x] next/previous in paginated response
- [ ] consume GET request body for parameters, and merge with query parameters and defaults
- [ ] allow for field filtering
