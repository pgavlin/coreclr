using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeValue_StructLayoutAttributeValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeValue_StructLayoutAttributeValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\structlayoutattribute\\StructLayoutAttributeValue\\StructLayoutAttributeValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
