using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanFalseString_BooleanFalseString_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanFalseString_BooleanFalseString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanFalseString\\BooleanFalseString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
