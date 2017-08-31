using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToChar14_ConvertToChar14_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToChar14_ConvertToChar14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToChar14\\ConvertToChar14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
