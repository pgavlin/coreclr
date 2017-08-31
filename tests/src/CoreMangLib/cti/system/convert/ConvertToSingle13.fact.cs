using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSingle13_ConvertToSingle13_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSingle13_ConvertToSingle13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSingle13\\ConvertToSingle13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
