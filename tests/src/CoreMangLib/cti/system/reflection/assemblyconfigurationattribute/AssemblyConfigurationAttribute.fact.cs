using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyconfigurationattribute_AssemblyConfigurationAttribute_AssemblyConfigurationAttribute_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyconfigurationattribute_AssemblyConfigurationAttribute_AssemblyConfigurationAttribute_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyconfigurationattribute\\AssemblyConfigurationAttribute\\AssemblyConfigurationAttribute.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
