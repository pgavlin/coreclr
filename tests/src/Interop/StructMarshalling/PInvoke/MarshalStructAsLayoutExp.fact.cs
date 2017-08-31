using CoreclrTestLib;
using Xunit;

namespace Interop_StructMarshalling
{
    class _PInvoke_MarshalStructAsLayoutExp_MarshalStructAsLayoutExp_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _PInvoke_MarshalStructAsLayoutExp_MarshalStructAsLayoutExp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\StructMarshalling\\PInvoke\\MarshalStructAsLayoutExp\\MarshalStructAsLayoutExp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
