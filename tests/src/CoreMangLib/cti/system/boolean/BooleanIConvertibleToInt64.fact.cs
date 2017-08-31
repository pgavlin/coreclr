using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToInt64_BooleanIConvertibleToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToInt64_BooleanIConvertibleToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToInt64\\BooleanIConvertibleToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
