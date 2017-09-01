using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Locals_static_passing_struct01_static_passing_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Locals_static_passing_struct01_static_passing_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Locals\\static_passing_struct01\\static_passing_struct01.cmd");
        }
    }
}
