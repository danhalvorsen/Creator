<table>
  <tbody>
    <tr>
      <th>Audio Shield<br />Signal</th>
      <th>Rev D, D2<br />(Teensy 4.x)</th>
      <th>Rev C<br />(Teensy 3.x)</th>
      <th>Required For</th>
      <th>Function</th>
    </tr>
    <tr style="color: red;background: yellow">
      <td>MCLK</td>
      <td>23<br />(MCLK1)</td>
      <td><br /></td>
      <td>Audio</td>
      <td>Audio Master Clock, 11.29 MHz</td>
    </tr>
    <tr style="color: orange">
      <td>BCLK</td>
      <td>21<br />(BCLK1)</td>
      <td><br /></td>
      <td>Audio</td>
      <td>Audio Bit Clock, 1.41 or 2.82 MHz</td>
    </tr>
    <tr style="color: purple">
      <td>LRCLK</td>
      <td>20<br />(LRCLK1)</td>
      <td><br /></td>
      <td>Audio</td>
      <td>Audio Left/Right Clock, 44.1 kHz</td>
    </tr>
    <tr style="color: grey;background: black">
      <td>DIN</td>
      <td>7<br />(OUT1A)</td>
      <td><br /></td>
      <td>Audio Output</td>
      <td>Audio Data from Teensy to Audio Shield<br />Goes to both headphone jack and Line-Out pins</td>
    </tr>
    <tr style="color: green;background: black">
      <td>DOUT</td>
      <td>8<br />(IN1)</td>
      <td><br /></td>
      <td>Audio Input</td>
      <td>Audio Data from Audio Shield to Teensy<br />Comes from either Microphone or Line-In pins</td>
    </tr>
    <tr style="color: red;background: black">
      <td>SCL</td>
      <td>19</td>
      <td> </td>
      <td>Audio Config</td>
      <td>Control Clock (I2C)</td>
    </tr>
    <tr style="color: yellow;background: black">
      <td>SDA</td>
      <td>18</td>
      <td></td>
      <td>Audio Config</td>
      <td>Control Data (I2C)</td>
    </tr>
    <tr style="color: green;background: grey">
      <td>SCK</td>
      <td>13</td>
      <td> </td>
      <td>Optional Data<br />SD or MEM</td>
      <td>Data Storage (SPI) Clock</td>
    </tr>
    <tr style="color: orange;background: grey">
      <td>MISO</td>
      <td>12</td>
      <td> </td>
      <td>Optional Data<br />SD or MEM</td>
      <td>Data Storage (SPI) from SD/MEM to Teensy</td>
    </tr>
    <tr style="color: blue;background: grey">
      <td>MOSI</td>
      <td>11</td>
      <td></td>
      <td>Optional Data<br />SD or MEM</td>
      <td>Data Storage (SPI) from Teensy to SD/MEM</td>
    </tr>
    <tr style="color: grey;background: skyblue">
      <td>SDCS</td>
      <td>10</td>
      <td></td>
      <td>Optional Data<br />SD Card</td>
      <td>Chip Select (SPI) for SD Card</td>
    </tr>
    <tr style="color: red;background: skyblue">
      <td>MEMCS</td>
      <td>6</td>
      <td></td>
      <td>Optional Data<br />MEM Chip</td>
      <td>Chip Select (SPI) for Memory Chip</td>
    </tr>
    <tr style="color: brown;background: skyblue">
      <td>Vol</td>
      <td>15 / A1</td>
      <td></td>
      <td>Optional Knob</td>
      <td>Volume Thumbwheel (analog signal)</td>
    </tr>

  </tbody>
</table>
