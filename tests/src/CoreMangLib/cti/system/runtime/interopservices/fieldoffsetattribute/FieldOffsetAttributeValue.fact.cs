using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_fieldoffsetattribute_FieldOffsetAttributeValue_FieldOffsetAttributeValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_fieldoffsetattribute_FieldOffsetAttributeValue_FieldOffsetAttributeValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\fieldoffsetattribute\\FieldOffsetAttributeValue\\FieldOffsetAttributeValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
