using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToInt32_BooleanIConvertibleToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToInt32_BooleanIConvertibleToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToInt32\\BooleanIConvertibleToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
