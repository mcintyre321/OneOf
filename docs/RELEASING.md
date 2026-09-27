# Releasing

Releases are driven by GitHub releases. Publishing a release runs [`.github/workflows/release.yml`](../.github/workflows/release.yml), which:

1. builds and tests the tagged commit, then packs it with the version taken from the tag,
2. attaches the `.nupkg`/`.snupkg` files to the GitHub release, and
3. after a maintainer approves the `nuget` environment, pushes the packages to nuget.org.

## Making a release

1. Update `<Version>` in `Directory.Build.props` and add a section to `CHANGELOG.md`, and merge that to `master`.
2. On GitHub, go to **Releases → Draft a new release**.
3. Create a tag `v<version>` on `master`, e.g. `v4.0.0` or `v4.0.0-preview.1`.
4. For a version with a suffix (`-preview.1`, `-rc.1`, ...), tick **Set as a pre-release**. The workflow refuses a mismatch.
5. Paste the changelog section into the notes (or use **Generate release notes**), then **Publish release**.
6. Approve the `publish` job when GitHub asks (Actions → the run → **Review deployments**).

If a job fails, fix the problem and re-run the workflow from the Actions tab. `--skip-duplicate` makes re-pushing safe.

## One-time setup

### nuget.org trusted publishing

No NuGet API key is stored in GitHub. Instead the workflow swaps a short-lived GitHub OIDC token for a NuGet key that lasts one hour.

1. On nuget.org, open **your username → Trusted Publishing** and add a policy:
   - **Repository owner:** `mcintyre321`
   - **Repository:** `OneOf`
   - **Workflow file:** `release.yml`
   - **Environment:** `nuget`
   - Package owner: the account that owns the `OneOf*` packages.
2. In the GitHub repo, go to **Settings → Secrets and variables → Actions → Variables** and add `NUGET_USER` set to your nuget.org username (the profile name, not your email).

### GitHub `nuget` environment

In **Settings → Environments**, create `nuget` and:

- add yourself under **Required reviewers**, so every publish needs a click from you;
- tick **Prevent self-review** only if there are other maintainers who can approve;
- under **Deployment branches and tags**, choose **Selected branches and tags** and add the tag rule `v*`.

### Old API keys

Once trusted publishing works, delete any existing nuget.org API keys that were used for this package, and make sure there are none stored in the repo's Actions secrets.
