using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_bindhandle_bindhandle1_bindhandle1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandle1_bindhandle1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandle1\\bindhandle1.cmd");
        }
    }
}
