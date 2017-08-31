using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDouble11_ConvertToDouble11_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDouble11_ConvertToDouble11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDouble11\\ConvertToDouble11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
