# *CorgiCoder's Shift Cipher*

Welcome to *CorgiCoder's Shift Cipher*! *CorgiCoder's Shift Cipher* is .NET's most optimized and efficient shift cipher.

## Table of Contents
1. [What is a Shift Cipher?](#what-is-a-shift-cipher)
    1. [Example](#example)
    2. [History and usage](#history-and-usage)
    3. [Breaking the cipher](#breaking-the-cipher)
    5. [Notes](#notes)
2. [How does *CorgiCoder's Shift Cipher* beat the competition?](#how-does-corgicoders-shift-cipher-beat-the-competition)

---

## What is a Shift Cipher?
In [cryptography](https://en.wikipedia.org/wiki/Cryptography), a **Caesar cipher**, also known as **Caesar's cipher**, the **shift cipher**, **Caesar's code** or **Caesar shift**, is one of the simplest and most widely known [encryption](https://en.wikipedia.org/wiki/Encryption) techniques. It is a type of [substitution cipher](https://en.wikipedia.org/wiki/Substitution_cipher) in which each letter in the [plaintext](https://en.wikipedia.org/wiki/Plaintext) is replaced by a letter some fixed number of positions down the [alphabet](https://en.wikipedia.org/wiki/Alphabet). For example, with a left shift of 3, `D` would be replaced by `A`, `E` would become `B`, and so on. The method is named after [Julius Caesar](https://en.wikipedia.org/wiki/Julius_Caesar), who used it in his private correspondence.<sup>[\[1\]](#notes)</sup>

The encryption step performed by a Caesar cipher is often incorperated as part of more complex schemes, such as the [Vigenère cipher](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher), and still has modern application in the [ROT13](https://en.wikipedia.org/wiki/ROT13) system. As with all single-alphabet substitution ciphers, the Caesar cipher is easily broken and in modern practice offers essentially no [communications security](https://en.wikipedia.org/wiki/Communications_security).

### Example

The transformation can be represented by aligning two alphabets; the cipher alphabet is teh plain alphabet rotated left or right by some number of positions. For instance, here is a Casear cipher using a left rotation of three places, equivalent fo a right shift of 23 (the shift parameter is used as the [key](https://en.wikipedia.org/wiki/Key_(cryptography))):

| Plain | Cipher |
|-------|--------|
| A | X |
| B | Y |
| C | Z |
| D | A |
| E | B |
| F | C |
| G | D |
| H | E |
| I | F |
| J | G |
| K | H |
| L | I |
| M | J |
| N | K |
| O | L |
| P | M |
| Q | N |
| R | O |
| S | P |
| T | Q |
| U | R |
| V | S |
| W | T |
| X | U |
| Y | V |
| Z | W |

When encrypting, a person looks up each letter of the message in the "plain" line and writes down the corresponding letter in the "cipher" line.

```
Plaintext:  THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
Ciphertext: QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD
```

Deciphering is done in reverse, with a right shift of 3.

The encryption can also be represented using [modular arithmetic](https://en.wikipedia.org/wiki/Modular_arithmetic) by first transforming the letters into numbers, according to the scheme, A &rarr; 0, B &rarr; 1, ..., Z &rarr; 25.<sup>[\[2\]](#notes)</sup> Encryption of a letter $x$ by a shift $n$ can be described mathematically as,<sup>[\[3\]](#notes)</sup>

$$
E_n(x) = (x + n) \mod{26}.
$$

Decription is performed similarly,

$$
D_n(x) = (x - n) \mod{26}.
$$

(Here, "mod" refers to the [modulo operation](https://en.wikipedia.org/wiki/Modulo_operation). The value $x$ is in the range 0 to 25, but if $x + n$ or $x - n$ are not in this range then 26 should be added or subtracted.)

The replacement remains the same throughout the message, so the cipher is classified as a type of [monoalphabetic substitution](https://en.wikipedia.org/wiki/Monoalphabetic_substitution), as opposed to [polyalphabetic substution](https://en.wikipedia.org/wiki/Polyalphabetic_substitution).

### History and usage
*See also: [History of cryptography](https://en.wikipedia.org/wiki/History_of_cryptography)*

The Caesar cipher is named after [Julius Caesar](https://en.wikipedia.org/wiki/Julius_Caesar), who, according to [Suetonius](https://en.wikipedia.org/wiki/Lives_of_the_Twelve_Caesars), used it with a shift of three (A becoming D when encrypting, and D becoming A when decrypting) to protect messages of military significance. While Caesar's was the first recorded use of this scheme, other substitution ciphers are known to have been used earlier.<sup>[\[4\]](#notes)[\[5\]](#notes)</sup>

> "If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out. If anyone wishes to decipher these, and get at their meaning, he must substitute the fourth letter of the alphabet, namely D for A, and so with the others." \
> &mdash; [Suetonius](https://en.wikipedia.org/wiki/Suetonius), [*Life of Julius Caesar*](https://en.wikipedia.org/wiki/Life_of_Julius_Caesar) 56

His nephew, [Augustus](https://en.wikipedia.org/wiki/Augustus_Caesar) also used the cipher, but with a right shift of one, and it did not wrap around to the beginning of the alphabet:

> "Whenever he wrote in cipher, he wrote B for A, C for B, and the rest of the letters on the same principal, using AA for Z." \
> &mdash; [Suetonius](https://en.wikipedia.org/wiki/Suetonius) [*Life of Augustus*](https://en.wikipedia.org/wiki/Life_of_Augustus) 88

Evidence now exists that Julius Caesar also used more complicated systems,<sup>[\[6\]](#notes)</sup> and one writer, [Aulus Gellius](https://en.wikipedia.org/wiki/Aulus_Gellius), refers to a (now lost) treatise on his ciphers:

> "There is even a rather ingeniously written treatise by the grammarian Probus concerning the secret meaning of letters in the composition of Caesar's epistles." \
> &mdash; [Aulus Gellius](https://en.wikipedia.org/wiki/Aulus_Gellius), Attic Nights 17.9.1-5

It is unknown how effective the Caesar cipher was at the time; there is no record at that time of any techniques for the solution of simple substitution ciphers. The earliest surviving records date to the 9th-century works of [Al-Kindi](https://en.wikipedia.org/wiki/Al-Kindi) in the [Arab](https://en.wikipedia.org/wiki/Arab) world with the discovery of [frequency analysis](https://en.wikipedia.org/wiki/Frequency_analysis).<sup>[\[7\]](#notes)</sup>

A piece of text encrypted in a [Hebrew](https://en.wikipedia.org/wiki/Hebrew_language) version of the Caesar cipher is sometimes found on the back of Jewish [mezuzah](https://en.wikipedia.org/wiki/Mezuzah) scrolls. When each letter is replaced with the letter before it in the [Hebrew alphabet](https://en.wikipedia.org/wiki/Hebrew_alphabet) the text translates as "[YHWH](https://en.wikipedia.org/wiki/YHWH), our God, YHWH", a quotation from the main part of the scroll.<sup>[\[8\]](#notes)[\[9\]](#notes)</sup>

In the 19th century, the personal advertisements section in newspapers would sometimes be used to exchange messages encrypted using simple cipher schemes. [Kahn](https://en.wikipedia.org/wiki/David_Kahn_(writer)) (1967) describes instances of lovers engaging in secret communications enciphered using the Caesar cipher in [*The Times*](https://en.wikipedia.org/wiki/The_Times).<sup>[\[10\]](#notes)</sup> Even as late as 1915, the Caesar cipher was in use: the Russian army employed it as a replacement for more complicated ciphers which had proved to be too difficult for their troops to master; German and Austrian [cryptanalysts](https://en.wikipedia.org/wiki/Cryptanalysis) had little difficulty in decrypting their messages.<sup>[\[11\]](#notes)</sup>

Caesar ciphers can be found today in children's toys such as [secret decoder rings](https://en.wikipedia.org/wiki/Secret_decoder_ring). A Caesar shift of thirteen is also performed in the [ROT13](https://en.wikipedia.org/wiki/ROT13) [algorithm](https://en.wikipedia.org/wiki/Algorithm), a simple method of obfuscating text widely found on [Usenet](https://en.wikipedia.org/wiki/Usenet) and used to obscure text (such as joke punchlines and story [spoilers](https://en.wikipedia.org/wiki/Spoiler_(media))), but not seriously used as a method of encryption.<sup>[\[12\]](#notes)</sup>

The [Vigenère cipher](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher) uses a Caesar cipher with a different shift at each position in the text; the value of the shift is defined using a repeating keyword.<sup>[\[13\]](#notes)</sup> If the keyword is as long as the message, is chosen at [random](https://en.wikipedia.org/wiki/Randomly), never becomes known to anyone else, and is never reused, this is the [one-time pad](https://en.wikipedia.org/wiki/One-time_pad) cipher, proven unbreakable. However the problems involved in using a random key as long as the message make the one-time pad difficult to use in practice. Keywords shorter than the message (e.g., "[Complete Victory](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher#History)" used by the [Confederacy](https://en.wikipedia.org/wiki/Confederate_States_of_America) during the [American Civil War](https://en.wikipedia.org/wiki/American_Civil_War)), introduce a cyclic pattern that might be detected with a statistically advanced version of frequency analysis.<sup>[\[14\]](#notes)</sup>

In April 2006, fugitive [Mafia](https://en.wikipedia.org/wiki/Sicilian_Mafia) boss [Bernardo Provenzano](https://en.wikipedia.org/wiki/Bernardo_Provenzano) was captured in [Sicily](https://en.wikipedia.org/wiki/Sicily) partly because some of his messages, clumsily written in a variation of the Caesar cipher, were broken. Provenzano's cipher used numbers, so that "A" would be written as "4", "B" as "5", and so on.<sup>[\[15\]](#notes)</sup>

In 2011, Rajib Karim was convicted in the United Kingdom of "terrorism offences" after using the Caesar cipher to communicate with Bangladeshi Islamic activists discussing plots to blow up [British Airplanes](https://en.wikipedia.org/wiki/British_Airways) planes or disrupt their IT networks. Although the parties had access to far better encryption techniques (Karim himself used [PGP](https://en.wikipedia.org/wiki/Pretty_Good_Privacy) for data storage on computer disks), they chose to use their own scheme (implemented in [Microsoft Excel](https://en.wikipedia.org/wiki/Microsoft_Excel)), rejecting a more sophisticated code program called [Mujahedeen Secrets](https://en.wikipedia.org/wiki/Mujahedeen_Secrets) "because 'kaffirs', or non-believers, know about it, so it must be less secure."<sup>[\[16\]](#notes)</sup>

### Breaking the cipher
The Caesar cipher can be easily broken even in a [ciphertext-only scenario](https://en.wikipedia.org/wiki/Ciphertext-only_attack). Since there are only a limited number of possible shifts (25 in English), an attacker can mount a [brute force attack](https://en.wikipedia.org/wiki/Brute_force_attack) by deciphering the message, or part of it, using each possible shift. The correct description will be the one which makes sense as English text.<sup>[\[17\]](#notes)</sup> An example is shown on the right for the ciphertext "`exxegoexsrgi`"; the candidate plaintext for shift for "`attackatonce`" is the only one which makes sense as English text. Another type of brute force attack is to write out the alphabet beneath each letter of the ciphertext, starting at that letter. Again the correct decryption is the one which makes sense as English text. This technique is sometimes known as "completing the plain component".<sup>[\[18\]](#notes)[\[19\]](#notes)</sup>

| Decryption shift | Candidate plaintext |
| - | - |
| 0 | `exxegoexsrgi` |
| 1 | `dwwdfndwrqfh` |
| 2 | `cvvcemcvqpeg` |
| 3 | `buubdlbupodf` |
| ***4*** | ***`attackatonce`*** |
| 5 | `zsszbjzsnmbd` |
| 6 | `yrryaiyrmlac` |
...
| 23 | `haahjrhavujl` |
| 24 | `gzzgiqgzutik` |
| 25 | `fyyfhpfytshj` |

Another approach is to match up the frequency distribution of the letters. By graphing the frequencies of letters in the ciphertext, and by knowing the expected distribution of those letters in the original language of the plaintext, a human can easily spot the value of the shift by looking at the displacement of particular features of the graph. This is known as [frequency analysis](https://en.wikipedia.org/wiki/Frequency_analysis). For example, in the English language the plaintext frequencies of the letters `E`, `T` (usually most frequent), and `Q`, `Z` (typically least frequent) are particularly distinctive.<sup>[\[20\]](#notes)</sup>

### Notes
1. Suetonius, [*Vita Divi Julii*](http://thelatinlibrary.com/suetonius/suet.caesar.html#56) 56.6
2. Luciano, Dennis; Gordon Prichett (January 1987). "Cryptology: From Caesar Ciphers to Public-Key Cryptosystems". *The College Mathematics Journal*. **18** (1): 2-17. [CiteSeerX](https://en.wikipedia.org/wiki/CiteSeerX_(identifier)) [10.1.1.110.6123](https://citeseerx.ist.psu.edu/viewdoc/summary?doi=10.1.1.110.6123). [doi](https://en.wikipedia.org/wiki/Doi_(identifier)):[10.2307/2686311](https://doi.org/10.2307%2F2686311). [JSTOR](https://en.wikipedia.org/wiki/JSTOR_(identifier)) [2686311](https://www.jstor.org/stable/2686311)
3. Wobst, Reinhard (2001). [*Cryptology Unlocked*](https://archive.org/details/Cryptology_Unlocked). Wiley. p. 19. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-470-06064-3](https://en.wikipedia.org/wiki/Special:BookSources/978-0-470-06064-3).
4. ["Cracking the Code"](https://web.archive.org/web/20201226065538/https://www.cia.gov/news-information/featured-story-archive/2007-featured-story-archive/cracking-the-code.html). *Central Intelligence Agency*. Archived from [the original](https://www.cia.gov/news-information/featured-story-archive/2007-featured-story-archive/cracking-the-code.html) on 26 December 2020. Retrieved 21 February 2017.
5. [Singh, Simon](https://en.wikipedia.org/wiki/Simon_Singh) (2000). [*The Code Book*](https://en.wikipedia.org/wiki/The_Code_Book). Anchor. pp. [289&ndash;290](https://archive.org/details/codebook00simo/page/289). [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [0-385-49532-3](https://en.wikipedia.org/wiki/Special:BookSources/0-385-49532-3).
6. Reinke, Edgar C. (December 1962). "Classical Cryptography". *The Classical Journal*. **58** (3): 114.
7. [Singh, Simon](https://en.wikipedia.org/wiki/Simon_Singh) (2000). [*The Code Book*](https://en.wikipedia.org/wiki/The_Code_Book). Anchor. pp. [14&ndash;20](https://archive.org/details/codebook00simo/page/14). [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [0-385-49532-3](https://en.wikipedia.org/wiki/Special:BookSources/0-385-49532-3).
8. Eisenberg, Ronald L. (2004). *Jewish Traditions* (1st ed.). PhiladelphiaL: Jewish Publication Society. p. 582. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [9780827610392](https://en.wikipedia.org/wiki/Special:BookSources/9780827610392).
9. Sameth, Mark (2020). *The Name : a history of the dual-gendered Hebrew name for God*. Eugene, Oregon: Wipf &amp; Stock. pp. 5&ndash;6. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [9781532693830](https://en.wikipedia.org/wiki/Special:BookSources/9781532693830).
10. [Kahn, David](https://en.wikipedia.org/wiki/David_Kahn_(writer)) (1967). *The Codebreakers*. pp. 775&ndash;6. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-684-83130-5](https://en.wikipedia.org/wiki/Special:BookSources/978-0-684-83130-5).
11. [Kahn, David](https://en.wikipedia.org/wiki/David_Kahn_(writer)) (1967). *The Codebreakers*. pp. 631&ndash;2. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-684-83130-5](https://en.wikipedia.org/wiki/Special:BookSources/978-0-684-83130-5).
12. Wobst, Reinhard (2001). [*Cryptology Unlocked*](https://archive.org/details/Cryptology_Unlocked). Wiley. p. 20. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-470-06064-3](https://en.wikipedia.org/wiki/Special:BookSources/978-0-470-06064-3).
13. [Kahn, David](https://en.wikipedia.org/wiki/David_Kahn_(writer)) (1967). *The Codebreakers*. p. 148-149. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-684-83130-5](https://en.wikipedia.org/wiki/Special:BookSources/978-0-684-83130-5).
14. [Kahn, David](https://en.wikipedia.org/wiki/David_Kahn_(writer)) (1967). *The Codebreakers*. pp. 398&ndash;400. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-684-83130-5](https://en.wikipedia.org/wiki/Special:BookSources/978-0-684-83130-5).
15. Leyden, John (2006-04-19). ["Mafia boss undone by clumsy crypto"](https://www.theregister.co.uk/2006/04/19/mafia_don_clueless_crypto/). [The Register](https://en.wikipedia.org/wiki/The_Register). Retrieved 2008-06-13.
16. ["BA jihadist relied on Jesus-era encryption"](https://www.theregister.co.uk/2011/03/22/ba_jihadist_trial_sentencing/). [The Register](https://en.wikipedia.org/wiki/The_Register). 2011-03-22. Retrieved 2011-04-01.
17. [Beutelspacher, Albrecht](https://en.wikipedia.org/wiki/Albrecht_Beutelspacher) (1994). *Cryptology*. [Mathematical Association of America](https://en.wikipedia.org/wiki/Mathematical_Association_of_America). pp. 8&ndash;9. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [0-88385-504-6](https://en.wikipedia.org/wiki/Special:BookSources/0-88385-504-6).
18. Leighton, ALbert C. (April 1969). "Secret Communication among the Greeks and Romans". *Technology and Culture*. **10** (2): 139&ndash;154. [doi](https://en.wikipedia.org/wiki/Doi_(identifier)):[10.2307/3101474](https://doi.org/10.2307%2F3101474). [JSTOR](https://en.wikipedia.org/wiki/JSTOR_(identifier)) [3101474](https://www.jstor.org/stable/3101474).
19. [Sinkov, Abraham](https://en.wikipedia.org/wiki/Abraham_Sinkov); Paul L. Irwin (1966). *Elementary Cryptanalysis: A Mathematical Approach*. Mathematical Association of America. pp. 13&ndash;15. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [0-88385-622-0](https://en.wikipedia.org/wiki/Special:BookSources/0-88385-622-0).

## How does *CorgiCoder's Shift Cipher* beat the competition?
