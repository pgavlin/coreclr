using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6410_ConvertToUInt6410_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6410_ConvertToUInt6410_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6410\\ConvertToUInt6410.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
