using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_typeattributes_TypeAttributesNestedFamORAssem_TypeAttributesNestedFamORAssem_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_typeattributes_TypeAttributesNestedFamORAssem_TypeAttributesNestedFamORAssem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\typeattributes\\TypeAttributesNestedFamORAssem\\TypeAttributesNestedFamORAssem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
