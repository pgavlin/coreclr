using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt322_ConvertToUInt322_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt322_ConvertToUInt322_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt322\\ConvertToUInt322.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
