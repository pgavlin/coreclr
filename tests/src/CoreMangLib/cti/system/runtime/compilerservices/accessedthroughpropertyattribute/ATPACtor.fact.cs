using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_accessedthroughpropertyattribute_ATPACtor_ATPACtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_accessedthroughpropertyattribute_ATPACtor_ATPACtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\accessedthroughpropertyattribute\\ATPACtor\\ATPACtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
