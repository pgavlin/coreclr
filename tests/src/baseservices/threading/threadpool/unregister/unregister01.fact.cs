using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_unregister_unregister01_unregister01_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_unregister_unregister01_unregister01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\unregister\\unregister01\\unregister01.cmd");
        }
    }
}
