# Why :heart: contribute

If you've made it this far, it's probably because you're thinking about contributing to this project.

We welcome you and encourage you to contribute to improving this project. Of course, in that case, your name will be added to the contribution list. :smile: :white_check_mark:

In this project, we value any contribution, no matter how small. That's why we don't have a section for first-time contributions.

1. Little things make a big difference. Just choose something you're interested in and start working on it.

2. If you have any questions, please ask. There's a lot of code. ![Discord-chat](https://img.shields.io/discord/680332596693172234?color=blue&logo=discord&logoColor=white)

## Code of Conduct

This project has a [Code of Conduct](https://github.com/Rigui73/dotnet-app-suite/CODE_OF_CONDUCT.md). We expect everyone who participates to abide by it. Please report any unacceptable behavior to [contacto@adriarigall.com](mailto:contacto@adriarigall.com).

## Table of Contents

- [Why :heart: contribute](#why-heart-contribute)
  - [Code of Conduct](#code-of-conduct)
  - [Table of Contents](#table-of-contents)
  - [Security Vulnerabilities](#security-vulnerabilities)
  - [Prepare the workspace](#prepare-the-workspace)
    - [Fork and create a branch](#fork-and-create-a-branch)
    - [Build \& Packaging](#build--packaging)
    - [Implement Your Fix or Feature](#implement-your-fix-or-feature)
    - [Get the Style Right](#get-the-style-right)
    - [Add a Change Log Entry](#add-a-change-log-entry)
  - [Issues](#issues)
    - [Issue types and statuses](#issue-types-and-statuses)
  - [Pull Request](#pull-request)
    - [Pull Request Tags](#pull-request-tags)
  - [Submit Suggestions and Improvements](#submit-suggestions-and-improvements)
  - [Styleguides](#styleguides)
    - [Git `Commit` Messages](#git-commit-messages)
    - [Documentation](#documentation)
  - [Community](#community)
    - [Final Words](#final-words)

## Security Vulnerabilities

If you discover a security vulnerability, we would appreciate it if you did not disclose it publicly. The [issue](https://www.github.com/Rigui73/dotnet-issue) section and the [mailing list](https://www.github.com/Rigui73/BashShell/.mailmap) are completely public. If you need to reach system developers in a non-public way, please report the issue to [contacto@adriarigall.com](mailto:contacto@adriarigall.com)

## Prepare the workspace

### Fork and create a branch

Create a branch of the project using `feature-id`, `hotfix-id`, `test-id` or `docs-id`.

- `feature` - For improvements and new developments.
- `hotfix` - For bugs and fixes.
- `test` - For testing.
- `docs` - For documentation.
- `id` - Number assigned on GitHub.

Example:

`sh git checkout -b feature-625`

### Build & Packaging

Pull requests to fix compilation or packaging issues on other operating systems or package managers will be gladly accepted, but issues without code fixes will be closed as stated above.

### Implement Your Fix or Feature

At this point, you're ready to make your changes! Feel free to ask for help; everyone is a beginner at first :smile_cat:

### Get the Style Right

Your contribution should follow the same style guidelines as the rest of the project. You can check for and fix style issues by running each linter individually. Run `bin/rake -T lint` to see the available linters. Format your code with [Prettier](https://github.com/prettier/prettier).

### Add a Change Log Entry

If your PR includes user-observable changes, you'll be prompted to add a record in [CHANGELOG](./CHANGELOG.md)

The change log format is as follows:

- One line per PR describing its fix or enhancement.
- Entries end with a period, followed by "[#pr-number] by [@github-username]".
- Entries are added to the "Unreleased" section at the top of the file, under the "Bug Fixes" or "Enhancements" subsection.

## Issues

- **Do not open a GitHub issue if the bug is a security vulnerability**, and instead refer to ours.

- **Make sure the bug hasn't already been reported** by searching GitHub under [Issues](https://github.com/rails/rails/issues).

- We only track bugs in the two most recently published versions on GitHub. If you are using an older version, please contact your distribution's bug tracker.

- When filing an issue, please specify the version you are experiencing the issue with. Also, please indicate which distribution you are using.

- Include an explanation on how to reproduce the issue you are reporting.

> **Note:** If you find a **Closed** issue that appears to be the same as the one you are experiencing, please open a new issue and include a link to the original issue in the body of the new issue.

- If you cannot find an open issue that addresses the problem, please open a new one. If possible, use the relevant bug report templates to create the issue. Simply copy the contents of the appropriate template into an .rb file, make the necessary changes to demonstrate the issue, and paste the contents into the issue description.

- [**Active Record** (models, database) issues](https://github.com/rails/rails/blob/master/guides/bug_report_templates/active_record_master.rb)
- [**Action Pack** (controllers, routing) issues](https://github.com/rails/rails/blob/master/guides/bug_report_templates/action_controller_master.rb)
- [**Generic template** for other issues](https://github.com/rails/rails/blob/master/guides/bug_report_templates/generic_master.rb)

### Issue types and statuses

| Tag | Description |
| ------------------ | ----------------------------------------------------------------------- |
| `enhancement` | Requests for improvements. |
| `bug` | Confirmed bugs or reports that are most likely bugs. |
| `question` | Questions rather than bug reports or feature requests. |
| `help-wanted` | Community help is appreciated. |
| `more-information` | More information should be gathered. |
| `duplicate` | Issues that are duplicates, i.e., have been reported previously. |
| `invalid` | Issues that are invalid (e.g., user errors). |

## Pull Request

Contributions to the project are welcome. Please review our style guide before submitting changes. If you'd like to help with the project, you can choose an open issue from the issue tracker.

1. Fork and clone 'master'.
2. Create a branch to contain your changes.
3. Hack away.
4. Add your own tests and make sure they're all working.
5. If any of your changes warrant mention on the homepage, edit the [CHANGELOG.md](https://www.github.com/Rigui73/Riguipedia/CHANGELOG.md).
6. Push a branch to your fork on GitHub.
7. Submit a pull request for the project.

_Notes:_
_Do not change the version number; we'll do that ourselves._

### Pull Request Tags

| Tag | Description |
| ----------- | ----------- |
| `work-in-progress` | Pull requests that are still being worked on; more changes will follow. |
| `needs-review` | Pull requests that need code review and maintainer approval. |
| `under-review` | Pull requests are being reviewed by the core team. |
| `requires-changes` | Pull requests that need to be updated based on review comments and then reviewed again. |
| `needs-testing` | Pull requests that require manual testing. |

## Submit Suggestions and Improvements

- **Use a clear and descriptive title** for the issue to identify the suggestion.
- **Provide a step-by-step description of the suggested improvement** with as much detail as possible.
- **Describe the current behavior** and **explain what behavior you expected to see instead** and why.
- **Include screenshots and animated GIFs** that help you demonstrate the steps or point out the part of the project the suggestion relates to. You can use [this tool](https://www.cockos.com/licecap/) to record GIFs on macOS and Windows, and [this tool](https://github.com/colinkeenan/silentcast) or [this tool](https://github.com/GNOME/byzanz) on Linux.

## Styleguides

### Git `Commit` Messages

- The `Add feature` present tense is used.
- Limit to 72 characters or less. Detailed explanations are in [CHANGELOG.md](/CHANGELOG.md).
- When only documentation has been changed, include `[doc update]` in the commit title.
- Consider starting the commit with an emoji:
- :art: `:art:` when improving code formatting/structure
- :rocket: `:rocket:` for optimizations or performance improvements.
- :non-potable_water: `:non-potable_water:` when connecting memory leaks
- :memo: `:memo:` when writing documents
- :penguin: `:penguin:` when fixing something on Linux
- :apple: `:apple:` when fixing something on macOS
- :checkered_flag: `:checkered_flag:` when fixing something on Windows
- :bug: `:bug:` when fixing a bug
- :fire: `:fire:` when removing code or files
- :green_heart: `:green_heart:` when fixing CI builds
- :white_check_mark: `:white_check_mark:` when adding tests
- :lock: `:lock:` when dealing with security
- :arrow_up: `:arrow_up:` when updating dependencies
- :arrow_down: `:arrow_down:` when downgrading dependencies
- :shirt: `:shirt:` when removing linter warnings
- :recycle: `:recycle:` for refactorings.

✨ for new features.
🔧 for configuration changes.

### Documentation

- [Markdown](https://daringfireball.net/projects/markdown) is used.

## Community

We use Discord to communicate with each other. :point_right: ![Discord Chat](https://img.shields.io/discord/680332596693172234?color=blue&logo=discord&logoColor=white)

### Final Words

We apologize in advance if we can't process and respond to your issue or PR immediately. We have a lot of work to do, but we're doing our best!
