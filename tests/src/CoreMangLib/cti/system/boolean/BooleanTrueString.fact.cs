using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanTrueString_BooleanTrueString_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanTrueString_BooleanTrueString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanTrueString\\BooleanTrueString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
