namespace DownKyi.Images;

public class ButtonIcon
{
    private static ButtonIcon instance;

    public static ButtonIcon Instance()
    {
        if (instance == null)
        {
            instance = new ButtonIcon();
        }

        return instance;
    }

    public ButtonIcon()
    {
        GeneralSearch = new VectorImage
        {
            Height = 20,
            Width = 20,
            Data =
                @"M697.91 755.7 q-132.36 103.48 -290.59 98.06 q-158.23 -5.41 -278.56 -120.92 q-127.54 -133.56 -128.75 -304.43                  q-1.21 -170.86 120.33 -304.43 q127.55 -126.34 297.21 -123.94 q169.66 2.41 303.22 123.94 q110.71 114.31 122.14 263.52                  q11.43 149.21 -75.21 275.55 l238.25 239.45 q18.05 18.05 18.05 42.12 q0 24.06 -18.05 41.51 q-18.05 17.45 -42.12 17.45                  q-24.07 0 -42.12 -16.85 l-223.81 -231.03 ZM643.76 647.41 q92.66 -96.26 92.66 -219 q0 -122.73 -92.66 -218.99 q-96.26 -92.66 -219 -92.66                  q-122.74 0 -218.99 92.66 q-92.65 96.26 -92.65 218.99 q0 122.74 92.65 219 q96.26 92.65 218.99 90.25 q122.74 -2.4 219 -90.25 Z",
            Fill = "#FF000000"
        };

        Settings = new VectorImage
        {
            Height = 32,
            Width = 32,
            Data =
                @"M19.4,13c0-0.3,0.1-0.6,0.1-1s0-0.7-0.1-1l2.1-1.7c0.2-0.2,0.2-0.4,0.1-0.6l-2-3.5C19.5,5,19.3,5,19,5l-2.5,1                  c-0.5-0.4-1.1-0.7-1.7-1l-0.4-2.7C14.5,2.2,14.3,2,14,2h-4C9.8,2,9.5,2.2,9.5,2.4L9.1,5.1C8.5,5.3,8,5.7,7.4,6L5,5                  C4.7,5,4.5,5,4.3,5.3l-2,3.5C2.2,9,2.3,9.2,2.5,9.4L4.6,11c0,0.3-0.1,0.6-0.1,1s0,0.7,0.1,1l-2.1,1.7c-0.2,0.1-0.2,0.4-0.1,0.6                  l2,3.5C4.5,19,4.7,19,5,19l2.5-1c0.5,0.4,1.1,0.7,1.7,1l0.4,2.7c0,0.2,0.2,0.4,0.5,0.4h4c0.3,0,0.5-0.2,0.5-0.4l0.4-2.7                  c0.6-0.3,1.2-0.6,1.7-1l2.5,1c0.2,0.1,0.5,0,0.6-0.2l2-3.5c0.1-0.2,0.1-0.5-0.1-0.6L19.4,13z M12,15.5c-1.9,0-3.5-1.6-3.5-3.5                  s1.6-3.5,3.5-3.5s3.5,1.6,3.5,3.5S13.9,15.5,12,15.5z",
            Fill = "#FF000000"
        };

        DownloadManage = new VectorImage
        {
            Height = 27,
            Width = 32,
            //Height =  20,
            //Width =  24,
            Data =
                @"M24,34c-2.4,0-4.9,0-7.3,0c-2.8,0-4.6-1.9-4.6-4.7c0-3.5,0-7,0-10.5c0-2.9,1.9-4.7,4.6-4.7c1.3,0,2.6,0,3.9,0               c1.1-0.1,2,0.4,2.7,1.3c1.1,1.7,2.6,2.3,4.6,2.1c1.3-0.2,2.6-0.1,4,0c2.5,0.2,4,1.7,4.2,4.3c0.2,2.7,0.2,5.5,0,8.3               c-0.2,2.4-2,4-4.3,4C29,34,26.5,34,24,34L24,34z                  M23.9,32.6c2.5,0,5,0,7.5,0c1.7,0,2.9-1,3-2.7c0.2-2.8,0.2-5.6,0-8.5               c-0.1-1.5-1.1-2.4-2.5-2.6c-1.3-0.2-2.6-0.1-3.9-0.1c-4.1-0.1-3,0.5-6-2.6c-0.5-0.5-1-0.8-1.7-0.8c-1.3,0-2.5,0-3.8,0               c-2,0-3.2,1.2-3.3,3.2c0,3.6,0,7.1,0,10.7c0,2,1.2,3.2,3.2,3.2C19,32.6,21.5,32.6,23.9,32.6L23.9,32.6z               M29.9,14.2h3.3c0.5,0,0.9,0,0.9,0.7c0,0.7-0.4,0.8-0.9,0.8c-2.2,0-4.5,0-6.7,0c-0.5,0-0.9-0.1-0.9-0.7               s0.4-0.7,0.9-0.7C27.6,14.2,28.7,14.2,29.9,14.2L29.9,14.2z M23.3,27.6v-5.4c0-0.5,0-1.1,0.7-1.1c0.7,0,0.6,0.6,0.6,1v5.2               c0.7-0.7,1.2-1.2,1.7-1.7c0.3-0.4,0.7-0.7,1.2-0.2c0.5,0.5,0.1,0.9-0.2,1.2c-0.9,1-1.8,1.9-2.7,2.8c-0.4,0.5-0.8,0.5-1.3,0.1               c-1-1-2-2.1-3-3.1c-0.3-0.3-0.4-0.7-0.1-1c0.3-0.4,0.7-0.3,1,0.1C22,26.1,22.6,26.7,23.3,27.6L23.3,27.6z",
            Fill = "#FF000000"
        };

        Toolbox = new VectorImage
        {
            Height = 28, // 21
            Width = 32, // 24
            Data = @"M20.2,14.5c-0.8,2.3-3.4,3.6-5.7,2.7c-1.3-0.5-2.3-1.5-2.7-2.7H5.5V13h21v1.5H20.2z M18.6,14.5h-5.2               c0.8,1.4,2.7,1.9,4.1,1.1C18,15.3,18.3,15,18.6,14.5L18.6,14.5z M10,8.5V7c0-0.8,0.7-1.5,1.5-1.5h9C21.3,5.5,22,6.2,22,7v1.5h4.5           	     c0.8,0,1.5,0.7,1.5,1.5v15c0,0.8-0.7,1.5-1.5,1.5l0,0h-21C4.7,26.5,4,25.8,4,25l0,0V10c0-0.8,0.7-1.5,1.5-1.5H10z M11.5,8.5h9V7h-9               V8.5z M5.5,10v15h21V10H5.5z",
            Fill = "#FF000000"
        };

        Trash = new VectorImage
        {
            Height = 20,
            Width = 20,
            Data =
                @"M683 85 q0 -27 -20.5 -55 q-20.5 -28 -65.5 -30 l-170 0 q-39 1 -62 23.5 q-23 22.5 -24 61.5 l-341 0 l0 86 l1024 0 l0 -86                  l-341 0 ZM341 256 l86 0 l0 597 l-86 0 l0 -597 ZM597 256 l86 0 l0 597 l-86 0 l0 -597 ZM853 853 q0 39 -23 62                  q-23 23 -62 24 l-512 0 q-39 -1 -62 -24 q-23 -23 -23 -62 l0 -597 l-86 0 l0 597 q2 73 50.5 121 q48.5 48 120.5 50 l512 0                  q72 -2 120.5 -50 q48.5 -48 50.5 -121 l0 -597 l-86 0 l0 597 Z",
            Fill = "#FF000000"
        };

        Delete = new VectorImage
        {
            Height = 18,
            Width = 18,
            Data =
                @"M634.29 513.52 l364.34 -363.32 q25.37 -27.4 25.37 -60.89 q0 -33.49 -26.38 -59.88 q-26.38 -26.39 -59.88 -26.39                  q-33.49 0 -60.9 25.38 l-363.32 364.33 l-363.32 -372.45 q-28.42 -20.3 -65.46 -20.3 q-37.04 0 -64.44 20.3                  q-20.3 27.4 -20.3 64.44 q0 37.04 20.3 65.46 l372.45 363.32 l-364.33 363.32 q-25.38 27.41 -25.38 60.9 q0 33.49 26.39 59.88                  q26.39 26.38 59.88 26.38 q33.49 0 60.89 -25.37 l363.32 -364.34 l363.32 364.34 q27.41 25.37 60.9 25.37 q33.49 0 59.88 -26.38                  q26.38 -26.38 26.38 -59.88 q0 -33.49 -25.37 -60.9 l-364.34 -363.32 Z",
            Fill = "#FF000000"
        };

        Start = new VectorImage
        {
            Height = 20,
            Width = 17,
            Data =
                @"M895.12 402.34 l-633.28 -383.81 q-30.16 -17.82 -64.43 -18.51 q-34.27 -0.69 -65.11 16.45 q-30.84 17.13 -47.97 47.29                  q-17.13 30.16 -17.13 64.42 l0 767.62 q0 34.27 17.13 63.74 q17.14 29.47 47.97 47.29 q30.84 17.82 65.11 17.13                  q34.27 -0.69 64.43 -18.5 l633.28 -383.81 q28.79 -17.82 45.24 -46.6 q16.45 -28.79 16.45 -63.06 q0 -34.27 -16.45 -63.05                  q-16.45 -28.79 -45.24 -46.61 Z",
            Fill = "#FF000000"
        };

        Pause = new VectorImage
        {
            Height = 20,
            Width = 15,
            Data =
                @"M255.66 0 q-53.75 0 -90.97 37.21 q-37.21 37.21 -37.21 90.96 l0 769.04 q1.38 55.12 37.21 90.95 q35.84 35.84 90.28 35.84                  q54.44 0 90.96 -35.84 q36.52 -35.83 37.9 -90.95 l0 -769.04 q-1.38 -53.75 -38.59 -90.96 q-37.21 -37.21 -89.58 -37.21                  ZM768.34 0 q-52.37 0 -89.58 37.21 q-37.21 37.21 -38.59 90.96 l0 769.04 q1.38 55.12 37.9 90.95 q36.52 35.84 90.96 35.84                  q54.44 0 90.28 -35.84 q35.83 -35.83 37.21 -90.95 l0 -769.04 q0 -53.75 -37.21 -90.96 q-37.22 -37.21 -90.97 -37.21 Z",
            Fill = "#FF000000"
        };

        Retry = new VectorImage
        {
            Height = 20,
            Width = 20,
            Data = @"M536.69 128.65 q-161.14 5.2 -270.3 113.71 q-109.15 108.5 -113.05 269.64 q3.9 161.14 113.05 269.64                  q109.16 108.5 270.3 113.71 q101.36 -1.3 185.82 -47.43 q84.47 -46.13 140.35 -129.3 q6.5 -14.3 22.09 -24.7                  q15.6 -10.39 31.19 -10.39 q28.59 0 47.44 18.85 q18.84 18.85 20.14 48.74 q0 11.69 -5.2 20.79 q0 3.9 0 7.8 l-3.9 5.19                  q-72.77 111.76 -185.82 174.78 q-113.06 63.03 -246.91 64.33 q-102.66 0 -196.22 -38.34 q-93.57 -38.33 -166.34 -111.11                  q-72.77 -72.77 -111.1 -166.34 q-38.33 -93.56 -38.33 -196.22 q0 -102.66 38.33 -196.23 q38.34 -93.56 111.1 -166.33                  q72.77 -72.77 166.34 -111.1 q93.56 -38.34 196.22 -38.34 q92.26 0 176.73 31.19 q84.47 31.19 152.04 89.66 l0 -25.99                  q1.3 -27.29 18.2 -44.83 q16.89 -17.54 42.88 -17.54 q25.99 0 44.18 18.19 q18.19 18.19 18.19 44.18 l0 189.73                  q0 24.69 -18.19 42.88 q-18.19 18.19 -42.88 18.19 l-191.03 0 q-24.69 0 -42.88 -18.19 q-18.2 -18.19 -18.2 -42.88                  q0 -28.59 16.25 -47.43 q16.25 -18.84 44.84 -20.13 l37.69 0 q-51.98 -42.89 -114.36 -65.63 q-62.38 -22.74 -128.65 -22.74 Z",
            Fill = "#FF000000"
        };

        Folder = new VectorImage
        {
            Height = 16,
            Width = 20,
            Data = @"M18,2H10L8,0H2A2,2,0,0,0,0,2V14a2,2,0,0,0,2,2H18a2,2,0,0,0,2-2V4A2,2,0,0,0,18,2Zm0,12H2V4H18Z",
            Fill = "#FF000000"
        };
    }

    public VectorImage GeneralSearch { get; private set; }
    public VectorImage Settings { get; private set; }
    public VectorImage DownloadManage { get; private set; }
    public VectorImage Toolbox { get; private set; }

    public VectorImage Trash { get; private set; }
    public VectorImage Delete { get; private set; }
    public VectorImage Start { get; private set; }
    public VectorImage Pause { get; private set; }
    public VectorImage Retry { get; private set; }
    public VectorImage Folder { get; private set; }
}