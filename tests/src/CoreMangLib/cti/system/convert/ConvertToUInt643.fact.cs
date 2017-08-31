using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt643_ConvertToUInt643_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt643_ConvertToUInt643_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt643\\ConvertToUInt643.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
