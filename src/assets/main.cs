/*
! tailwindcss v3.2.0 | MIT License | https://tailwindcss.com
*//*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box; /* 1 */
  border-width: 0; /* 2 */
  border-style: solid; /* 2 */
  border-color: #e5e7eb; /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
*/

html {
  line-height: 1.5; /* 1 */
  -webkit-text-size-adjust: 100%; /* 2 */
  -moz-tab-size: 4; /* 3 */
  -o-tab-size: 4;
     tab-size: 4; /* 3 */
  font-family: DM Sans, sans-serif, Inter var, ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji"; /* 4 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0; /* 1 */
  line-height: inherit; /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0; /* 1 */
  color: inherit; /* 2 */
  border-top-width: 1px; /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace; /* 1 */
  font-size: 1em; /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0; /* 1 */
  border-color: inherit; /* 2 */
  border-collapse: collapse; /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit; /* 1 */
  font-size: 100%; /* 1 */
  font-weight: inherit; /* 1 */
  line-height: inherit; /* 1 */
  color: inherit; /* 1 */
  margin: 0; /* 2 */
  padding: 0; /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button; /* 1 */
  background-color: transparent; /* 2 */
  background-image: none; /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield; /* 1 */
  outline-offset: -2px; /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button; /* 1 */
  font: inherit; /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1; /* 1 */
  color: #9ca3af; /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1; /* 1 */
  color: #9ca3af; /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/
:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block; /* 1 */
  vertical-align: middle; /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */
[hidden] {
  display: none;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}
.container {
  width: 100%;
}
@media (min-width: 640px) {

  .container {
    max-width: 640px;
  }
}
@media (min-width: 768px) {

  .container {
    max-width: 768px;
  }
}
@media (min-width: 1024px) {

  .container {
    max-width: 1024px;
  }
}
@media (min-width: 1280px) {

  .container {
    max-width: 1280px;
  }
}
@media (min-width: 1536px) {

  .container {
    max-width: 1536px;
  }
}
.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  padding: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  white-space: nowrap;
  border-width: 0;
}
.static {
  position: static;
}
.fixed {
  position: fixed;
}
.absolute {
  position: absolute;
}
.relative {
  position: relative;
}
.inset-0 {
  top: 0px;
  right: 0px;
  bottom: 0px;
  left: 0px;
}
.right-0 {
  right: 0px;
}
.top-0 {
  top: 0px;
}
.z-50 {
  z-index: 50;
}
.z-40 {
  z-index: 40;
}
.z-10 {
  z-index: 10;
}
.m-auto {
  margin: auto;
}
.mx-auto {
  margin-left: auto;
  margin-right: auto;
}
.mx-2 {
  margin-left: 0.5rem;
  margin-right: 0.5rem;
}
.mt-4 {
  margin-top: 1rem;
}
.mt-1 {
  margin-top: 0.25rem;
}
.mb-4 {
  margin-bottom: 1rem;
}
.mt-2 {
  margin-top: 0.5rem;
}
.mr-4 {
  margin-right: 1rem;
}
.ml-auto {
  margin-left: auto;
}
.mb-2 {
  margin-bottom: 0.5rem;
}
.mr-auto {
  margin-right: auto;
}
.mb-6 {
  margin-bottom: 1.5rem;
}
.mr-3 {
  margin-right: 0.75rem;
}
.ml-2 {
  margin-left: 0.5rem;
}
.-mr-1 {
  margin-right: -0.25rem;
}
.mt-8 {
  margin-top: 2rem;
}
.ml-3 {
  margin-left: 0.75rem;
}
.-mr-12 {
  margin-right: -3rem;
}
.ml-1 {
  margin-left: 0.25rem;
}
.mt-5 {
  margin-top: 1.25rem;
}
.ml-4 {
  margin-left: 1rem;
}
.mt-3 {
  margin-top: 0.75rem;
}
.mb-8 {
  margin-bottom: 2rem;
}
.mb-3 {
  margin-bottom: 0.75rem;
}
.block {
  display: block;
}
.flex {
  display: flex;
}
.inline-flex {
  display: inline-flex;
}
.grid {
  display: grid;
}
.hidden {
  display: none;
}
.h-screen {
  height: 100vh;
}
.h-full {
  height: 100%;
}
.h-6 {
  height: 1.5rem;
}
.h-5 {
  height: 1.25rem;
}
.h-8 {
  height: 2rem;
}
.h-10 {
  height: 2.5rem;
}
.h-0 {
  height: 0px;
}
.h-16 {
  height: 4rem;
}
.h-4 {
  height: 1rem;
}
.h-24 {
  height: 6rem;
}
.h-\[100vh\] {
  height: 100vh;
}
.h-48 {
  height: 12rem;
}
.h-96 {
  height: 24rem;
}
.min-h-screen {
  min-height: 100vh;
}
.w-screen {
  width: 100vw;
}
.w-full {
  width: 100%;
}
.w-6 {
  width: 1.5rem;
}
.w-5 {
  width: 1.25rem;
}
.w-8 {
  width: 2rem;
}
.w-48 {
  width: 12rem;
}
.w-10 {
  width: 2.5rem;
}
.w-14 {
  width: 3.5rem;
}
.w-64 {
  width: 16rem;
}
.w-auto {
  width: auto;
}
.w-0 {
  width: 0px;
}
.w-4 {
  width: 1rem;
}
.w-16 {
  width: 4rem;
}
.w-24 {
  width: 6rem;
}
.w-11\/12 {
  width: 91.666667%;
}
.w-32 {
  width: 8rem;
}
.max-w-screen-xl {
  max-width: 1280px;
}
.max-w-2xl {
  max-width: 42rem;
}
.max-w-7xl {
  max-width: 80rem;
}
.max-w-xs {
  max-width: 20rem;
}
.max-w-none {
  max-width: none;
}
.max-w-6xl {
  max-width: 72rem;
}
.max-w-sm {
  max-width: 24rem;
}
.flex-1 {
  flex: 1 1 0%;
}
.flex-shrink-0 {
  flex-shrink: 0;
}
.origin-top-right {
  transform-origin: top right;
}
.-translate-x-full {
  --tw-translate-x: -100%;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}
.translate-x-0 {
  --tw-translate-x: 0px;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}
.scale-95 {
  --tw-scale-x: .95;
  --tw-scale-y: .95;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}
.scale-100 {
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}
.transform {
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}
@keyframes spin {

  to {
    transform: rotate(360deg);
  }
}
.animate-spin {
  animation: spin 1s linear infinite;
}
.cursor-pointer {
  cursor: pointer;
}
.resize {
  resize: both;
}
.grid-cols-2 {
  grid-template-columns: repeat(2, minmax(0, 1fr));
}
.grid-cols-1 {
  grid-template-columns: repeat(1, minmax(0, 1fr));
}
.flex-col {
  flex-direction: column;
}
.items-center {
  align-items: center;
}
.justify-end {
  justify-content: flex-end;
}
.justify-center {
  justify-content: center;
}
.justify-between {
  justify-content: space-between;
}
.gap-2 {
  gap: 0.5rem;
}
.gap-4 {
  gap: 1rem;
}
.space-y-6 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(1.5rem * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(1.5rem * var(--tw-space-y-reverse));
}
.space-y-1 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(0.25rem * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(0.25rem * var(--tw-space-y-reverse));
}
.space-y-5 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(1.25rem * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(1.25rem * var(--tw-space-y-reverse));
}
.place-self-center {
  place-self: center;
}
.overflow-hidden {
  overflow: hidden;
}
.overflow-y-auto {
  overflow-y: auto;
}
.rounded-lg {
  border-radius: 0.5rem;
}
.rounded-md {
  border-radius: 0.375rem;
}
.rounded-full {
  border-radius: 9999px;
}
.rounded-t-lg {
  border-top-left-radius: 0.5rem;
  border-top-right-radius: 0.5rem;
}
.border {
  border-width: 1px;
}
.border-r {
  border-right-width: 1px;
}
.border-none {
  border-style: none;
}
.border-gray-300 {
  --tw-border-opacity: 1;
  border-color: rgb(209 213 219 / var(--tw-border-opacity));
}
.border-gray-200 {
  --tw-border-opacity: 1;
  border-color: rgb(229 231 235 / var(--tw-border-opacity));
}
.bg-gray-50 {
  --tw-bg-opacity: 1;
  background-color: rgb(249 250 251 / var(--tw-bg-opacity));
}
.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}
.bg-gray-200 {
  --tw-bg-opacity: 1;
  background-color: rgb(229 231 235 / var(--tw-bg-opacity));
}
.bg-gray-100 {
  --tw-bg-opacity: 1;
  background-color: rgb(243 244 246 / var(--tw-bg-opacity));
}
.bg-gray-600 {
  --tw-bg-opacity: 1;
  background-color: rgb(75 85 99 / var(--tw-bg-opacity));
}
.bg-gray-800 {
  --tw-bg-opacity: 1;
  background-color: rgb(31 41 55 / var(--tw-bg-opacity));
}
.bg-gray-900 {
  --tw-bg-opacity: 1;
  background-color: rgb(17 24 39 / var(--tw-bg-opacity));
}
.bg-transparent {
  background-color: transparent;
}
.bg-orange-400 {
  --tw-bg-opacity: 1;
  background-color: rgb(251 146 60 / var(--tw-bg-opacity));
}
.bg-red-600 {
  --tw-bg-opacity: 1;
  background-color: rgb(220 38 38 / var(--tw-bg-opacity));
}
.bg-opacity-75 {
  --tw-bg-opacity: 0.75;
}
.p-2\.5 {
  padding: 0.625rem;
}
.p-2 {
  padding: 0.5rem;
}
.p-1 {
  padding: 0.25rem;
}
.p-5 {
  padding: 1.25rem;
}
.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}
.px-4 {
  padding-left: 1rem;
  padding-right: 1rem;
}
.py-1\.5 {
  padding-top: 0.375rem;
  padding-bottom: 0.375rem;
}
.py-1 {
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
}
.py-8 {
  padding-top: 2rem;
  padding-bottom: 2rem;
}
.py-3 {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
}
.px-5 {
  padding-left: 1.25rem;
  padding-right: 1.25rem;
}
.py-6 {
  padding-top: 1.5rem;
  padding-bottom: 1.5rem;
}
.px-2 {
  padding-left: 0.5rem;
  padding-right: 0.5rem;
}
.py-4 {
  padding-top: 1rem;
  padding-bottom: 1rem;
}
.px-6 {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}
.px-8 {
  padding-left: 2rem;
  padding-right: 2rem;
}
.py-12 {
  padding-top: 3rem;
  padding-bottom: 3rem;
}
.px-3 {
  padding-left: 0.75rem;
  padding-right: 0.75rem;
}
.pt-5 {
  padding-top: 1.25rem;
}
.pb-4 {
  padding-bottom: 1rem;
}
.pt-2 {
  padding-top: 0.5rem;
}
.text-center {
  text-align: center;
}
.text-lg {
  font-size: 1.125rem;
  line-height: 1.75rem;
}
.text-sm {
  font-size: 0.875rem;
  line-height: 1.25rem;
}
.text-4xl {
  font-size: 2.25rem;
  line-height: 2.5rem;
}
.text-base {
  font-size: 1rem;
  line-height: 1.5rem;
}
.text-2xl {
  font-size: 1.5rem;
  line-height: 2rem;
}
.text-xl {
  font-size: 1.25rem;
  line-height: 1.75rem;
}
.text-3xl {
  font-size: 1.875rem;
  line-height: 2.25rem;
}
.font-semibold {
  font-weight: 600;
}
.font-medium {
  font-weight: 500;
}
.font-normal {
  font-weight: 400;
}
.font-extrabold {
  font-weight: 800;
}
.font-light {
  font-weight: 300;
}
.font-bold {
  font-weight: 700;
}
.leading-none {
  line-height: 1;
}
.tracking-tight {
  letter-spacing: -0.025em;
}
.text-red-500 {
  --tw-text-opacity: 1;
  color: rgb(239 68 68 / var(--tw-text-opacity));
}
.text-gray-700 {
  --tw-text-opacity: 1;
  color: rgb(55 65 81 / var(--tw-text-opacity));
}
.text-gray-900 {
  --tw-text-opacity: 1;
  color: rgb(17 24 39 / var(--tw-text-opacity));
}
.text-black {
  --tw-text-opacity: 1;
  color: rgb(0 0 0 / var(--tw-text-opacity));
}
.text-inherit {
  color: inherit;
}
.text-gray-500 {
  --tw-text-opacity: 1;
  color: rgb(107 114 128 / var(--tw-text-opacity));
}
.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}
.text-gray-300 {
  --tw-text-opacity: 1;
  color: rgb(209 213 219 / var(--tw-text-opacity));
}
.text-gray-400 {
  --tw-text-opacity: 1;
  color: rgb(156 163 175 / var(--tw-text-opacity));
}
.text-blue-600 {
  --tw-text-opacity: 1;
  color: rgb(37 99 235 / var(--tw-text-opacity));
}
.text-current {
  color: currentColor;
}
.text-indigo-600 {
  --tw-text-opacity: 1;
  color: rgb(79 70 229 / var(--tw-text-opacity));
}
.opacity-0 {
  opacity: 0;
}
.opacity-100 {
  opacity: 1;
}
.opacity-25 {
  opacity: 0.25;
}
.opacity-75 {
  opacity: 0.75;
}
.shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}
.shadow-lg {
  --tw-shadow: 0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 10px 15px -3px var(--tw-shadow-color), 0 4px 6px -4px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}
.shadow-none {
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}
.shadow-sm {
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}
.shadow-md {
  --tw-shadow: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 4px 6px -1px var(--tw-shadow-color), 0 2px 4px -2px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}
.ring-1 {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(1px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}
.ring-black {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(0 0 0 / var(--tw-ring-opacity));
}
.ring-opacity-5 {
  --tw-ring-opacity: 0.05;
}
.filter {
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}
.transition {
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}
.transition-opacity {
  transition-property: opacity;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}
.duration-100 {
  transition-duration: 100ms;
}
.duration-75 {
  transition-duration: 75ms;
}
.duration-300 {
  transition-duration: 300ms;
}
.ease-out {
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
}
.ease-in {
  transition-timing-function: cubic-bezier(0.4, 0, 1, 1);
}
.ease-linear {
  transition-timing-function: linear;
}
.ease-in-out {
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
}

.btn {
  border-radius: 0.25rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  padding-left: 1rem;
  padding-right: 1rem;
}

.btn-blue {
  --tw-bg-opacity: 1;
  background-color: rgb(59 130 246 / var(--tw-bg-opacity));
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.btn-blue:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(29 78 216 / var(--tw-bg-opacity));
}

.card {
  overflow: hidden;
  border-radius: 0.25rem;
  --tw-shadow: 0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 10px 15px -3px var(--tw-shadow-color), 0 4px 6px -4px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.hover\:bg-transparent:hover {
  background-color: transparent;
}

.hover\:bg-gray-100:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(243 244 246 / var(--tw-bg-opacity));
}

.hover\:bg-gray-700:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(55 65 81 / var(--tw-bg-opacity));
}

.hover\:bg-orange-500:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(249 115 22 / var(--tw-bg-opacity));
}

.hover\:bg-gray-50:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(249 250 251 / var(--tw-bg-opacity));
}

.hover\:bg-red-700:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(185 28 28 / var(--tw-bg-opacity));
}

.hover\:text-white:hover {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.hover\:text-indigo-900:hover {
  --tw-text-opacity: 1;
  color: rgb(49 46 129 / var(--tw-text-opacity));
}

.focus\:border-blue-500:focus {
  --tw-border-opacity: 1;
  border-color: rgb(59 130 246 / var(--tw-border-opacity));
}

.focus\:bg-transparent:focus {
  background-color: transparent;
}

.focus\:outline-none:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.focus\:ring-4:focus {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(4px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}

.focus\:ring-2:focus {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(2px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}

.focus\:ring-inset:focus {
  --tw-ring-inset: inset;
}

.focus\:ring-blue-500:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(59 130 246 / var(--tw-ring-opacity));
}

.focus\:ring-gray-100:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(243 244 246 / var(--tw-ring-opacity));
}

.focus\:ring-indigo-500:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(99 102 241 / var(--tw-ring-opacity));
}

.focus\:ring-white:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(255 255 255 / var(--tw-ring-opacity));
}

.focus\:ring-orange-100:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(255 237 213 / var(--tw-ring-opacity));
}

.focus\:ring-offset-2:focus {
  --tw-ring-offset-width: 2px;
}

.active\:bg-transparent:active {
  background-color: transparent;
}

.disabled\:cursor-not-allowed:disabled {
  cursor: not-allowed;
}

.disabled\:opacity-70:disabled {
  opacity: 0.7;
}

.group:hover .group-hover\:text-gray-300 {
  --tw-text-opacity: 1;
  color: rgb(209 213 219 / var(--tw-text-opacity));
}

@media (prefers-color-scheme: dark) {

  .dark\:border-gray-600 {
    --tw-border-opacity: 1;
    border-color: rgb(75 85 99 / var(--tw-border-opacity));
  }

  .dark\:border-gray-700 {
    --tw-border-opacity: 1;
    border-color: rgb(55 65 81 / var(--tw-border-opacity));
  }

  .dark\:bg-gray-700 {
    --tw-bg-opacity: 1;
    background-color: rgb(55 65 81 / var(--tw-bg-opacity));
  }

  .dark\:bg-gray-900 {
    --tw-bg-opacity: 1;
    background-color: rgb(17 24 39 / var(--tw-bg-opacity));
  }

  .dark\:bg-gray-800 {
    --tw-bg-opacity: 1;
    background-color: rgb(31 41 55 / var(--tw-bg-opacity));
  }

  .dark\:bg-orange-300 {
    --tw-bg-opacity: 1;
    background-color: rgb(253 186 116 / var(--tw-bg-opacity));
  }

  .dark\:text-white {
    --tw-text-opacity: 1;
    color: rgb(255 255 255 / var(--tw-text-opacity));
  }

  .dark\:text-gray-400 {
    --tw-text-opacity: 1;
    color: rgb(156 163 175 / var(--tw-text-opacity));
  }

  .dark\:placeholder-gray-400::-moz-placeholder {
    --tw-placeholder-opacity: 1;
    color: rgb(156 163 175 / var(--tw-placeholder-opacity));
  }

  .dark\:placeholder-gray-400::placeholder {
    --tw-placeholder-opacity: 1;
    color: rgb(156 163 175 / var(--tw-placeholder-opacity));
  }

  .dark\:hover\:bg-gray-700:hover {
    --tw-bg-opacity: 1;
    background-color: rgb(55 65 81 / var(--tw-bg-opacity));
  }

  .dark\:hover\:bg-orange-400:hover {
    --tw-bg-opacity: 1;
    background-color: rgb(251 146 60 / var(--tw-bg-opacity));
  }

  .dark\:focus\:border-blue-500:focus {
    --tw-border-opacity: 1;
    border-color: rgb(59 130 246 / var(--tw-border-opacity));
  }

  .dark\:focus\:ring-blue-500:focus {
    --tw-ring-opacity: 1;
    --tw-ring-color: rgb(59 130 246 / var(--tw-ring-opacity));
  }

  .dark\:focus\:ring-gray-800:focus {
    --tw-ring-opacity: 1;
    --tw-ring-color: rgb(31 41 55 / var(--tw-ring-opacity));
  }

  .dark\:focus\:ring-orange-400:focus {
    --tw-ring-opacity: 1;
    --tw-ring-color: rgb(251 146 60 / var(--tw-ring-opacity));
  }
}

@media (min-width: 640px) {

  .sm\:mx-auto {
    margin-left: auto;
    margin-right: auto;
  }

  .sm\:w-full {
    width: 100%;
  }

  .sm\:max-w-md {
    max-width: 28rem;
  }

  .sm\:rounded-lg {
    border-radius: 0.5rem;
  }

  .sm\:px-6 {
    padding-left: 1.5rem;
    padding-right: 1.5rem;
  }

  .sm\:px-10 {
    padding-left: 2.5rem;
    padding-right: 2.5rem;
  }

  .sm\:text-4xl {
    font-size: 2.25rem;
    line-height: 2.5rem;
  }
}

@media (min-width: 768px) {

  .md\:ml-6 {
    margin-left: 1.5rem;
  }

  .md\:flex {
    display: flex;
  }

  .md\:hidden {
    display: none;
  }

  .md\:w-4\/5 {
    width: 80%;
  }

  .md\:flex-shrink-0 {
    flex-shrink: 0;
  }

  .md\:grid-cols-2 {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .md\:flex-row {
    flex-direction: row;
  }

  .md\:justify-between {
    justify-content: space-between;
  }

  .md\:space-x-10 > :not([hidden]) ~ :not([hidden]) {
    --tw-space-x-reverse: 0;
    margin-right: calc(2.5rem * var(--tw-space-x-reverse));
    margin-left: calc(2.5rem * calc(1 - var(--tw-space-x-reverse)));
  }

  .md\:px-8 {
    padding-left: 2rem;
    padding-right: 2rem;
  }

  .md\:text-5xl {
    font-size: 3rem;
    line-height: 1;
  }

  .md\:text-lg {
    font-size: 1.125rem;
    line-height: 1.75rem;
  }
}

@media (min-width: 1024px) {

  .lg\:col-span-7 {
    grid-column: span 7 / span 7;
  }

  .lg\:col-span-5 {
    grid-column: span 5 / span 5;
  }

  .lg\:mb-0 {
    margin-bottom: 0px;
  }

  .lg\:mt-0 {
    margin-top: 0px;
  }

  .lg\:mb-8 {
    margin-bottom: 2rem;
  }

  .lg\:block {
    display: block;
  }

  .lg\:inline-block {
    display: inline-block;
  }

  .lg\:flex {
    display: flex;
  }

  .lg\:hidden {
    display: none;
  }

  .lg\:grid-cols-12 {
    grid-template-columns: repeat(12, minmax(0, 1fr));
  }

  .lg\:grid-cols-3 {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .lg\:flex-row {
    flex-direction: row;
  }

  .lg\:items-center {
    align-items: center;
  }

  .lg\:gap-6 {
    gap: 1.5rem;
  }

  .lg\:gap-8 {
    gap: 2rem;
  }

  .lg\:px-8 {
    padding-left: 2rem;
    padding-right: 2rem;
  }

  .lg\:py-4 {
    padding-top: 1rem;
    padding-bottom: 1rem;
  }

  .lg\:py-16 {
    padding-top: 4rem;
    padding-bottom: 4rem;
  }

  .lg\:text-xl {
    font-size: 1.25rem;
    line-height: 1.75rem;
  }
}

@media (min-width: 1280px) {

  .xl\:gap-0 {
    gap: 0px;
  }

  .xl\:text-6xl {
    font-size: 3.75rem;
    line-height: 1;
  }
}