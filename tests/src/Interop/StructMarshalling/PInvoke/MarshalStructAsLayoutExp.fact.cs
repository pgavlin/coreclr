using CoreclrTestLib;
using Xunit;

namespace Interop_StructMarshalling
{
    public class _PInvoke_MarshalStructAsLayoutExp_MarshalStructAsLayoutExp_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _PInvoke_MarshalStructAsLayoutExp_MarshalStructAsLayoutExp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\StructMarshalling\\PInvoke\\MarshalStructAsLayoutExp\\MarshalStructAsLayoutExp.cmd");
        }
    }
}
