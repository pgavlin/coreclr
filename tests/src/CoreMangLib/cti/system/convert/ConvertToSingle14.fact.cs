using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSingle14_ConvertToSingle14_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSingle14_ConvertToSingle14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSingle14\\ConvertToSingle14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
