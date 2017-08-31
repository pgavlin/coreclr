using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDouble5_ConvertToDouble5_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDouble5_ConvertToDouble5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDouble5\\ConvertToDouble5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
