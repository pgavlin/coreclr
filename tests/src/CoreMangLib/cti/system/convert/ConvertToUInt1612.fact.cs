using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1612_ConvertToUInt1612_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1612_ConvertToUInt1612_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1612\\ConvertToUInt1612.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
