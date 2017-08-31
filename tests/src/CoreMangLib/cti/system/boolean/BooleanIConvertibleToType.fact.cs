using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToType_BooleanIConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToType_BooleanIConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToType\\BooleanIConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
