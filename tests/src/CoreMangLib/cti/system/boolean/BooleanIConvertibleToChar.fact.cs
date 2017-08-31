using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToChar_BooleanIConvertibleToChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToChar_BooleanIConvertibleToChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToChar\\BooleanIConvertibleToChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
