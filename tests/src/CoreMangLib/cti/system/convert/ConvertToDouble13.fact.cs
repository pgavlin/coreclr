using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDouble13_ConvertToDouble13_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDouble13_ConvertToDouble13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDouble13\\ConvertToDouble13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
