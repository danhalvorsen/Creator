<table>
  <tbody>
    <tr>
      <th>Audio Shield<br />Signal</th>
      <th>Rev D, D2<br />(Teensy 4.x)</th>
      <th>Rev C<br />(Teensy 3.x)</th>
      <th>Required For</th>
      <th>Function</th>
    </tr>
    <tr>
    <span style="color: red;">text</span>.
      <td>MCLK</td>
      <td>23<br />(MCLK1)</td>
      <td>11<br />(MCLK)</td>
      <td>Audio</td>
      <td>Audio Master Clock, 11.29 MHz</td>
    </tr>
    <tr>
      <td>BCLK</td>
      <td>21<br />(BCLK1)</td>
      <td>9<br />(BCLK)</td>
      <td>Audio</td>
      <td>Audio Bit Clock, 1.41 or 2.82 MHz</td>
    </tr>
    <tr>
      <td>LRCLK</td>
      <td>20<br />(LRCLK1)</td>
      <td>23<br />(LRCLK)</td>
      <td>Audio</td>
      <td>Audio Left/Right Clock, 44.1 kHz</td>
    </tr>
    <tr>
      <td>DIN</td>
      <td>7<br />(OUT1A)</td>
      <td>22<br />(OUT)</td>
      <td>Audio Output</td>
      <td>Audio Data from Teensy to Audio Shield<br />Goes to both headphone jack and Line-Out pins</td>
    </tr>
    <tr>
      <td>DOUT</td>
      <td>8<br />(IN1)</td>
      <td>13<br />(IN)</td>
      <td>Audio Input</td>
      <td>Audio Data from Audio Shield to Teensy<br />Comes from either Microphone or Line-In pins</td>
    </tr>
    <tr>
      <td>SCL</td>
      <td>19</td>
      <td>19</td>
      <td>Audio Config</td>
      <td>Control Clock (I2C)</td>
    </tr>
    <tr>
      <td>SDA</td>
      <td>18</td>
      <td>18</td>
      <td>Audio Config</td>
      <td>Control Data (I2C)</td>
    </tr>
    <tr>
      <td>SCK</td>
      <td>13</td>
      <td>14</td>
      <td>Optional Data<br />SD or MEM</td>
      <td>Data Storage (SPI) Clock</td>
    </tr>
    <tr>
      <td>MISO</td>
      <td>12</td>
      <td>12</td>
      <td>Optional Data<br />SD or MEM</td>
      <td>Data Storage (SPI) from SD/MEM to Teensy</td>
    </tr>
    <tr>
      <td>MOSI</td>
      <td>11</td>
      <td>7</td>
      <td>Optional Data<br />SD or MEM</td>
      <td>Data Storage (SPI) from Teensy to SD/MEM</td>
    </tr>
    <tr>
      <td>SDCS</td>
      <td>10</td>
      <td>10</td>
      <td>Optional Data<br />SD Card</td>
      <td>Chip Select (SPI) for SD Card</td>
    </tr>
    <tr>
      <td>MEMCS</td>
      <td>6</td>
      <td>6</td>
      <td>Optional Data<br />MEM Chip</td>
      <td>Chip Select (SPI) for Memory Chip</td>
    </tr>
    <tr>
      <td>Vol</td>
      <td>15 / A1</td>
      <td>15 / A1</td>
      <td>Optional Knob</td>
      <td>Volume Thumbwheel (analog signal)</td>
    </tr>

  </tbody>
</table>
