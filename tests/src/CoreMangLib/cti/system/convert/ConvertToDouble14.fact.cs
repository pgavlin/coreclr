using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDouble14_ConvertToDouble14_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDouble14_ConvertToDouble14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDouble14\\ConvertToDouble14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
