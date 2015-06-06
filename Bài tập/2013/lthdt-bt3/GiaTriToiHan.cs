﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XuLySoLieu
{
    static class GiaTriToiHan
    {
        //                    0.00   0.01   0.02   0.03   0.04   0.05   0.06   0.07   0.08   0.09  
        static double[] u = { .5000, .4960, .4920, .4880, .4840, .4801, .4761, .4721, .4681, .4641, // 0.0
                              .4602, .4562, .4522, .4483, .4443, .4404, .4364, .4325, .4286, .4247, // 0.1
                              .4207, .4168, .4129, .4090, .4052, .4013, .3974, .3936, .3897, .3859, // 0.2
                              .3821, .3783, .3745, .3707, .3669, .3632, .3594, .3557, .3520, .3483, // 0.3
                              .3446, .3409, .3372, .3336, .3300, .3264, .3228, .3192, .3156, .3121, // 0.4

                              .3085, .3050, .3015, .2981, .2946, .2912, .2877, .2843, .2810, .2776, // 0.5
                              .2743, .2709, .2676, .2643, .2611, .2578, .2546, .2514, .2483, .2451, // 0.6
                              .2420, .2389, .2358, .2327, .2296, .2266, .2236, .2206, .2177, .2148, // 0.7
                              .2119, .2090, .2061, .2033, .2005, .1977, .1949, .1922, .1894, .1867, // 0.8
                              .1841, .1814, .1788, .1762, .1736, .1711, .1685, .1660, .1635, .1611, // 0.9

                              .1587, .1562, .1539, .1515, .1492, .1469, .1446, .1423, .1401, .1379, // 1.0
                              .1357, .1335, .1314, .1292, .1271, .1251, .1230, .1210, .1190, .1170, // 1.1
                              .1151, .1131, .1112, .1093, .1075, .1056, .1038, .1020, .1003, .0985, // 1.2
                              .0968, .0951, .0934, .0918, .0901, .0885, .0869, .0853, .0838, .0823, // 1.3
                              .0808, .0793, .0778, .0764, .0749, .0735, .0721, .0708, .0694, .0681, // 1.4

                              .0668, .0655, .0643, .0630, .0618, .0606, .0594, .0582, .0571, .0559, // 1.5
                              .0548, .0537, .0526, .0516, .0505, .0495, .0485, .0475, .0465, .0455, // 1.6
                              .0446, .0436, .0427, .0418, .0409, .0401, .0392, .0384, .0375, .0367, // 1.7
                              .0359, .0351, .0344, .0336, .0329, .0322, .0314, .0307, .0301, .0294, // 1.8
                              .0287, .0281, .0274, .0268, .0262, .0256, .0250, .0244, .0239, .0233, // 1.9

                              .0228, .0222, .0217, .0212, .0207, .0202, .0197, .0192, .0188, .0183, // 2.0
                              .0179, .0174, .0170, .0166, .0162, .0158, .0154, .0150, .0146, .0143, // 2.1
                              .0139, .0136, .0132, .0129, .0125, .0122, .0119, .0116, .0113, .0110, // 2.2
                              .0107, .0104, .0102, .0099, .0096, .0094, .0091, .0089, .0087, .0084, // 2.3
                              .0082, .0080, .0078, .0075, .0073, .0071, .0069, .0068, .0066, .0064, // 2.4

                              .0062, .0060, .0059, .0057, .0055, .0054, .0052, .0051, .0049, .0048, // 2.5
                              .0047, .0045, .0044, .0043, .0041, .0040, .0039, .0038, .0037, .0036, // 2.6
                              .0035, .0034, .0033, .0032, .0031, .0030, .0029, .0028, .0027, .0026, // 2.7
                              .0026, .0025, .0024, .0023, .0023, .0022, .0021, .0021, .0020, .0019, // 2.8
                              .0019, .0018, .0018, .0017, .0016, .0016, .0015, .0015, .0014, .0014, // 2.9

                              .0013, .0013, .0013, .0012, .0012, .0011, .0011, .0011, .0010, .0010, // 3.0
                              .0010, .0009, .0009, .0009, .0008, .0008, .0008, .0008, .0007, .0007, // 3.1
                              .0007, .0007, .0006, .0006, .0006, .0006, .0006, .0005, .0005, .0005, // 3.2
                              .0005, .0005, .0005, .0004, .0004, .0004, .0004, .0004, .0004, .0003, // 3.3
                              .0003, .0003, .0003, .0003, .0003, .0003, .0003, .0003, .0003, .0002, // 3.4

                              .0002, .0002, .0002, .0002, .0002, .0002, .0002, .0002, .0002, .0002, // 3.5
                              .0002, .0002, .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, // 3.6
                              .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, // 3.7
                              .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, .0001, // 3.8
                              .0000, .0000, .0000, .0000, .0000, .0000, .0000, .0000, .0000, .0000  // 3.9
                            };

        public static double LayGiaTriU(double alphaTren2)
        {
            int index = (int)Math.Round(alphaTren2 * 100, 2);

            if (index < 0) return u[0];
            if (index > 400) return u[399];

            return u[index];
        }

        //                       0.2    0.15   0.1    0.05   0.025  0.01   0.005  0.0025 0.001
        static double[,] t = { { 1.376, 1.963, 3.078, 6.314, 12.71, 31.82, 63.66, 127.3, 318.3}, // 1
                               { 1.061, 1.386, 1.886, 2.920, 4.303, 6.965, 9.925, 14.09, 22.33}, // 2
                               { 0.978, 1.250, 1.638, 2.353, 3.182, 4.541, 5.841, 7.453, 10.22}, // 3
                               { 0.941, 1.190, 1.533, 2.132, 2.776, 3.747, 4.604, 5.598, 7.173}, // 4
                               { 0.920, 1.156, 1.476, 2.015, 2.571, 3.365, 4.032, 4.773, 5.893}, // 5

                               { 0.906, 1.134, 1.440, 1.943, 2.447, 3.143, 3.707, 4.317, 5.208}, // 6
                               { 0.896, 1.119, 1.415, 1.895, 2.365, 2.998, 3.499, 4.029, 4.785}, // 7
                               { 0.889, 1.108, 1.397, 1.860, 2.306, 2.896, 3.355, 3.833, 4.501}, // 8
                               { 0.883, 1.100, 1.383, 1.833, 2.262, 2.821, 3.250, 3.690, 4.297}, // 9
                               { 0.879, 1.093, 1.372, 1.812, 2.228, 2.764, 3.169, 3.581, 4.144}, // 10

                               { 0.876, 1.088, 1.363, 1.796, 2.201, 2.718, 3.106, 3.497, 4.025}, // 11
                               { 0.873, 1.083, 1.356, 1.782, 2.179, 2.681, 3.055, 3.428, 3.930}, // 12
                               { 0.870, 1.079, 1.350, 1.771, 2.160, 2.650, 3.012, 3.372, 3.852}, // 13
                               { 0.868, 1.076, 1.345, 1.761, 2.145, 2.624, 2.977, 3.326, 3.787}, // 14
                               { 0.866, 1.074, 1.341, 1.753, 2.131, 2.602, 2.947, 3.286, 3.733}, // 15
                               
                               { 0.865, 1.071, 1.337, 1.746, 2.120, 2.583, 2.921, 3.252, 3.686}, // 16
                               { 0.863, 1.069, 1.333, 1.740, 2.110, 2.567, 2.898, 3.222, 3.646}, // 17
                               { 0.862, 1.067, 1.330, 1.734, 2.101, 2.552, 2.878, 3.197, 3.610}, // 18
                               { 0.861, 1.066, 1.328, 1.729, 2.093, 2.539, 2.861, 3.174, 3.579}, // 19
                               { 0.860, 1.064, 1.325, 1.725, 2.086, 2.528, 2.845, 3.153, 3.552}, // 20

                               { 0.859, 1.063, 1.323, 1.721, 2.080, 2.518, 2.831, 3.135, 3.527}, // 21
                               { 0.858, 1.061, 1.321, 1.717, 2.074, 2.508, 2.819, 3.119, 3.505}, // 22
                               { 0.858, 1.060, 1.319, 1.714, 2.069, 2.500, 2.807, 3.104, 3.485}, // 23
                               { 0.857, 1.059, 1.318, 1.711, 2.064, 2.492, 2.797, 3.091, 3.467}, // 24
                               { 0.856, 1.058, 1.316, 1.708, 2.060, 2.485, 2.787, 3.078, 3.450}, // 25

                               { 0.856, 1.058, 1.315, 1.706, 2.056, 2.479, 2.779, 3.067, 3.435}, // 26
                               { 0.855, 1.057, 1.314, 1.703, 2.052, 2.473, 2.771, 3.057, 3.421}, // 27
                               { 0.855, 1.056, 1.313, 1.701, 2.048, 2.467, 2.763, 3.047, 3.408}, // 28
                               { 0.854, 1.055, 1.311, 1.699, 2.045, 2.462, 2.756, 3.038, 3.396}, // 29
                               { 0.854, 1.055, 1.310, 1.697, 2.042, 2.457, 2.750, 3.030, 3.385}, // 30

                               { 0.851, 1.050, 1.303, 1.684, 2.021, 2.423, 2.704, 2.971, 3.307}, // 40
                               { 0.849, 1.047, 1.299, 1.676, 2.009, 2.403, 2.678, 2.937, 3.261}, // 50
                               { 0.848, 1.045, 1.296, 1.671, 2.000, 2.390, 2.660, 2.915, 3.232}, // 60
                               { 0.847, 1.044, 1.294, 1.667, 1.994, 2.381, 2.648, 2.899, 3.211}, // 70
                               { 0.846, 1.043, 1.292, 1.664, 1.990, 2.374, 2.639, 2.887, 3.195}, // 80

                               { 0.846, 1.042, 1.291, 1.662, 1.987, 2.368, 2.632, 2.878, 3.183}, // 90
                               { 0.845, 1.042, 1.290, 1.660, 1.984, 2.364, 2.626, 2.871, 3.174}, // 100
                               { 0.845, 1.041, 1.289, 1.658, 1.980, 2.358, 2.617, 2.860, 3.160}, // 120
                               { 0.843, 1.039, 1.285, 1.651, 1.970, 2.342, 2.596, 2.833, 3.125}, // 240
                               { 0.842, 1.036, 1.282, 1.645, 1.960, 2.326, 2.576, 2.807, 3.090}  // ∞
                             };

        public static double LayGiaTriT(double alpha2, int n)
        {
            int i, j;

            if (n <= 30) i = n - 1;
            else if (n <= 40) i = 30;
            else if (n <= 50) i = 31;
            else if (n <= 60) i = 32;
            else if (n <= 70) i = 33;
            else if (n <= 80) i = 34;
            else if (n <= 90) i = 35;
            else if (n <= 100) i = 36;
            else if (n <= 120) i = 37;
            else if (n <= 240) i = 38;
            else i = 39;

            if (alpha2 <= 0.001) j = 8;
            else if (alpha2 <= 0.0025) j = 7;
            else if (alpha2 <= 0.005) j = 6;
            else if (alpha2 <= 0.01) j = 5;
            else if (alpha2 <= 0.025) j = 4;
            else if (alpha2 <= 0.05) j = 3;
            else if (alpha2 <= 0.1) j = 2;
            else if (alpha2 <= 0.15) j = 1;
            else j = 0;

            return t[i, j];
        }
    }
}
