using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_Monitor_TryEnter01_TryEnter01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_TryEnter01_TryEnter01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\TryEnter01\\TryEnter01.cmd");
        }
    }
}
