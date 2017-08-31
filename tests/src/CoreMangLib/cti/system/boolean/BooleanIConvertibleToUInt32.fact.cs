using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToUInt32_BooleanIConvertibleToUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToUInt32_BooleanIConvertibleToUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToUInt32\\BooleanIConvertibleToUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
