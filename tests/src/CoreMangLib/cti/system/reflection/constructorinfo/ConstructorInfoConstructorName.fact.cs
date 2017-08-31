using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_constructorinfo_ConstructorInfoConstructorName_ConstructorInfoConstructorName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_constructorinfo_ConstructorInfoConstructorName_ConstructorInfoConstructorName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\constructorinfo\\ConstructorInfoConstructorName\\ConstructorInfoConstructorName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
