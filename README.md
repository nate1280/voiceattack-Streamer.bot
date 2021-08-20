# VoiceAttack Streamer.Bot

This VoiceAttack plugin allows for the running of actions in Streamer.bot

Using UDP communications, you can have VoiceAttack, by way of this plugin, send an action request to Streamer.bot to do an action.

## Usage
* Create your command
* Add a `Set text value` under `Other` -> `Advanced`
* Configure it like the screenshot below

![Set Text Value Screenshot](https://raw.githubusercontent.com/nate1280/voiceattack-Streamer.bot/main/_assets/set_text_value.png)

* Next add an `Execute an External Plugin Function` under `Other` -> `Advanced`
* Pick the `Streamer.bot Action Runner - v1.0` like in the screenshot below

![Execute an External Plugin Function Screenshot](https://raw.githubusercontent.com/nate1280/voiceattack-Streamer.bot/main/_assets/execute_external_plugin.png)

That's it, you're done!  You should have a command in Voice Attack setup similar to the screenshot below.

![Add a Command Screenshot](https://raw.githubusercontent.com/nate1280/voiceattack-Streamer.bot/main/_assets/add_command.png)

## NOTES
This plugin requires [Streamer.bot](https://streamer.bot) to work.

This is a very basic plugin for VoiceAttack