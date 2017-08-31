using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanGetHashCode_BooleanGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanGetHashCode_BooleanGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanGetHashCode\\BooleanGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
