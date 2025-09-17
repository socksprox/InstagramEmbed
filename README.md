# InstagramEmbed (vxinstagram)

**InstagramEmbed** is a lightweight Instagram link embedding tool designed for Discord and other platforms supporting the [Open Graph Protocol (OGP)](https://ogp.me/). It offers full support for embedding Instagram photos and videos, enabling seamless previews across chats, forums, and websites.

Unlike traditional solutions that rely on limited scraping techniques, InstagramEmbed leverages the [Snapsave Media Downloader](https://github.com/ahmedrangel/snapsave-media-downloader) for robust and consistent content retrieval—ensuring compatibility with the majority of public Instagram media.

## Features

- Embed Instagram **photos** and **videos** anywhere OGP is supported
- Powered by the reliable SnapSave API
- Fast response 

## Supports

- ✅ Posts (www.instagram.com/p).
- ✅ Reels (www.instagram.com/reel(s)).
- ✅ Stories (www.instagram.com/stories/username).
- ✅ Albums (www.instagram.com/p/).
- ✅ User Posts (www.instagram.com/username/p).
- ✅ Share (www.instagram.com/share/p).
- ✅ Singular Media in Album (www.instagram.com/p/[hash]/1).
- ✅ With or Without Post Details (vxinstagram.com / d.vxinstagram.com).
- ❌ User information, list of reels, list of posts, tags, and search queries.

## How It Works

1. User pastes an Instagram link with "vx" at the beginning (vxinstagram) (e.g., into Discord).
2. The page generates a preview with embedded media using Open Graph tags.
3. The platform (e.g., Discord) renders the embed automatically.

## API Integration

InstagramEmbed uses this backend API for fetching Instagram content:

**Snapsave Media Downloader [ahmedrangel](https://github.com/ahmedrangel)**  
🔗 https://github.com/ahmedrangel/snapsave-media-downloader

## Credits

- [Snapsave Media Downloader by Ahmed Rangel](https://github.com/ahmedrangel/snapsave-media-downloader)
- UI & backend by [Lainmode](https://github.com/Lainmode)
- Twitter: [@realAlita](https://twitter.com/realAlita)

## Support

If you like this project, consider [buying me a coffee](https://www.buymeacoffee.com/alsauce)!

## License

MIT License. See [`LICENSE`](./LICENSE) for details.
