using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_accessedthroughpropertyattribute_ATPAPropertyName_ATPAPropertyName_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_accessedthroughpropertyattribute_ATPAPropertyName_ATPAPropertyName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\accessedthroughpropertyattribute\\ATPAPropertyName\\ATPAPropertyName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
