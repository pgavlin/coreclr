using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToByte_BooleanIConvertibleToByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToByte_BooleanIConvertibleToByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToByte\\BooleanIConvertibleToByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
