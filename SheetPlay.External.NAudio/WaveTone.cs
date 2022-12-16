using NAudio.Wave;

namespace SheetPlay.External.NAudio
{
    public class WaveTone : WaveStream
    {
        private double Frequency;
        private double Amplitude;
        private double Time;

        public WaveTone(double frequency, double amplitude, double time)
        {
            this.Frequency = frequency;
            this.Amplitude = amplitude;
            this.Time = time;
        }

        public override WaveFormat WaveFormat { get { return new WaveFormat(44100, 16, 1); } }

        public override long Length => long.MaxValue;

        public override long Position { get; set; }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int samples = count / 2;
            for (int i = 0; i < samples; i++)
            {
                double sine = Amplitude * Math.Sin(Math.PI * 2 * Frequency * Time);
                Time += 1.0 / 44100;
                short truncated = (short)Math.Round(sine * (Math.Pow(2, 15) - 1));
                buffer[i * 2] = (byte)(truncated & 0x00ff);
                buffer[i * 2 + 1] = (byte)((truncated & 0xff00) >> 8);
            }

            return count;
        }
    }
}