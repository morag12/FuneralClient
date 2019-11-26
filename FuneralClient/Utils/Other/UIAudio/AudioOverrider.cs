using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.Other.UIAudio
{
    public static class AudioOverrider
    {
        public static AudioSource _currentOutput;
        public static IEnumerator GetAudioClip(this string audioSrc)
        {
            WWW www = new WWW(audioSrc);
            yield return www;
            var audio = www.GetAudioClip();
            if (audio != null)
            {
                _currentOutput = new AudioSource()
                {
                    clip = audio,
                    bypassEffects = true,
                    bypassListenerEffects = true,
                    bypassReverbZones = true,
                    enabled = true,
                    loop = true,
                    name = audio.name,
                    volume = 1.0f
                };
            }
        }

        public static void Play(this AudioClip clip)
        {
            if (clip != null)
            {
                var source = new AudioSource()
                {
                    clip = clip,
                    bypassEffects = true,
                    bypassListenerEffects = true,
                    bypassReverbZones = true,
                    enabled = true,
                    loop = true,
                    name = clip.name,
                    volume = 1.0f
                };

                source.Play();
            }
        }

        public static void Play(this AudioSource source)
        {
            source.Play();
        }

        public static void PlayCurrentAudio()
        {
            if (_currentOutput == null) return;
            _currentOutput.Play();
        }
    }
}
