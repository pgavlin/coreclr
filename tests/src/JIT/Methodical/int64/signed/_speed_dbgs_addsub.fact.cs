using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _int64_signed__speed_dbgs_addsub__speed_dbgs_addsub_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__speed_dbgs_addsub__speed_dbgs_addsub_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_dbgs_addsub\\_speed_dbgs_addsub.cmd");
        }
    }
}
