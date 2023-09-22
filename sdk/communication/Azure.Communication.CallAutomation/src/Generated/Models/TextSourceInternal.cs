// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TextSource. </summary>
    internal partial class TextSourceInternal
    {
        /// <summary> Initializes a new instance of TextSourceInternal. </summary>
        /// <param name="text"> Text for the cognitive service to be played. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public TextSourceInternal(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
        }

        /// <summary> Text for the cognitive service to be played. </summary>
        public string Text { get; }
        /// <summary>
        /// Source language locale to be played
        /// Refer to available locales here: &lt;seealso href="https://learn.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support?tabs=stt-tts" /&gt;
        /// </summary>
        public string SourceLocale { get; set; }
        /// <summary> Voice kind type. </summary>
        public VoiceKind? VoiceKind { get; set; }
        /// <summary>
        /// Voice name to be played
        /// Refer to available Text-to-speech voices here: &lt;seealso href="https://learn.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support?tabs=stt-tts" /&gt;
        /// </summary>
        public string VoiceName { get; set; }
        /// <summary> Endpoint where the custom voice was deployed. </summary>
        public string CustomVoiceEndpointId { get; set; }
    }
}
