using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _MemberAccess_interface_struct01_interface_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_interface_struct01_interface_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\interface_struct01\\interface_struct01.cmd");
        }
    }
}
